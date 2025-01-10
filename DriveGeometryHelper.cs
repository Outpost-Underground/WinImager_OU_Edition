using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace WinImager
{
    internal static class DriveGeometryHelper
    {
        public static NativeMethods.DISK_GEOMETRY_EX GetDriveGeometryEx(string physicalDrivePath)
        {
            // 1) Open the drive
            SafeFileHandle hDevice = NativeMethods.CreateFile(
                physicalDrivePath,
                NativeMethods.GENERIC_READ,
                NativeMethods.FILE_SHARE_READ | NativeMethods.FILE_SHARE_WRITE,
                IntPtr.Zero,
                NativeMethods.OPEN_EXISTING,
                0,
                IntPtr.Zero);

            if (hDevice.IsInvalid)
            {
                throw new System.ComponentModel.Win32Exception(
                    Marshal.GetLastWin32Error(),
                    $"Failed to open {physicalDrivePath}");
            }

            // 2) Prepare outBuffer
            byte[] outBuffer = new byte[1024];
            int bytesReturned;

            // 3) Call IOCTL_DISK_GET_DRIVE_GEOMETRY_EX
            bool success = NativeMethods.DeviceIoControl(
                hDevice,
                NativeMethods.IOCTL_DISK_GET_DRIVE_GEOMETRY_EX,
                IntPtr.Zero,
                0,
                outBuffer,
                outBuffer.Length,
                out bytesReturned,
                IntPtr.Zero);

            if (!success)
            {
                hDevice.Close();
                throw new System.ComponentModel.Win32Exception(
                    Marshal.GetLastWin32Error(),
                    "IOCTL_DISK_GET_DRIVE_GEOMETRY_EX failed");
            }

            // 4) Marshal bytes -> DISK_GEOMETRY_EX
            NativeMethods.DISK_GEOMETRY_EX geometryEx;
            int sizeOfGeom = Marshal.SizeOf(typeof(NativeMethods.DISK_GEOMETRY_EX));
            IntPtr ptr = Marshal.AllocHGlobal(sizeOfGeom);
            try
            {
                Marshal.Copy(outBuffer, 0, ptr, sizeOfGeom);
                geometryEx = (NativeMethods.DISK_GEOMETRY_EX)
                    Marshal.PtrToStructure(ptr, typeof(NativeMethods.DISK_GEOMETRY_EX));
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
                hDevice.Close();
            }

            return geometryEx;
        }
    }
}
