using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace WinImager
{
    internal static class NativeMethods
    {
        // Constants for CreateFile
        public const int GENERIC_READ = unchecked((int)0x80000000);
        public const int FILE_SHARE_READ = 0x00000001;
        public const int FILE_SHARE_WRITE = 0x00000002;
        public const int OPEN_EXISTING = 3;

        // For Disk DeviceIoControl
        private const uint FILE_DEVICE_DISK = 0x00000007;
        private const uint METHOD_BUFFERED = 0;
        private const uint FILE_ANY_ACCESS = 0;

        // IOCTL_DISK_GET_DRIVE_GEOMETRY_EX -> 0x000700A0
        public static uint IOCTL_DISK_GET_DRIVE_GEOMETRY_EX =
            (FILE_DEVICE_DISK << 16) | (FILE_ANY_ACCESS << 14) | (0x0028 << 2) | METHOD_BUFFERED;

        [StructLayout(LayoutKind.Sequential)]
        public struct DISK_GEOMETRY
        {
            public long Cylinders;
            public int MediaType;
            public int TracksPerCylinder;
            public int SectorsPerTrack;
            public int BytesPerSector;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DISK_GEOMETRY_EX
        {
            public DISK_GEOMETRY Geometry;
            public long DiskSize;
            // More fields exist in real usage, but for our example we just need DiskSize + geometry
        }

        // CreateFile to open physical drive
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern SafeFileHandle CreateFile(
            string lpFileName,
            int dwDesiredAccess,
            int dwShareMode,
            IntPtr lpSecurityAttributes,
            int dwCreationDisposition,
            int dwFlagsAndAttributes,
            IntPtr hTemplateFile);

        // DeviceIoControl overload
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool DeviceIoControl(
            SafeFileHandle hDevice,
            uint dwIoControlCode,
            IntPtr lpInBuffer,
            int nInBufferSize,
            [Out] byte[] lpOutBuffer,
            int nOutBufferSize,
            out int lpBytesReturned,
            IntPtr lpOverlapped);
    }
}
