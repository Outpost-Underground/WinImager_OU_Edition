The WinImager utility with a custom skin. 

WinImager - Disk Imaging Utility (v1.0)

WinImager is a custom-built Windows disk imaging utility designed to create raw disk images from physical drives with error handling and logging. 
It provides users with a graphical interface to select a physical drive, choose a destination for the image file, and start the imaging process. 
The utility is designed to handle large drives and unreadable sectors, ensuring the imaging process completes reliably while maintaining a detailed 
record of any issues encountered.

Key Features:

✅ Physical Drive Selection

Automatically detects and lists all physical drives connected to the system (e.g., \\.\PHYSICALDRIVE0).
Displays drive size to help users identify the correct drive to image.

✅ Raw Disk Imaging

Creates a sector-by-sector image of the selected drive, including all readable sectors.
Supports large drives (e.g., 1TB+ external drives).
Uses DeviceIoControl (IOCTL_DISK_GET_DRIVE_GEOMETRY_EX) to obtain the drive’s true size and sector geometry, ensuring an accurate image.

✅ Error Handling

Automatically handles unreadable sectors by zero-filling them in the image file.
Logs all errors encountered during the imaging process, including sector numbers and error details.

✅ Detailed Logging & Reporting

Generates a .txt log file saved alongside the image file.
The log file includes:
Drive path and size
Total sectors read
Number of successful sectors
Number of sectors with errors (zero-filled)
Total bytes read
Any read errors encountered

✅ Progress Tracking

Provides real-time progress updates via a progress bar and percentage label in the UI.
Ensures the user can monitor the progress of the imaging process.

✅ User-Friendly Interface

Simple GUI built with WinForms for easy use.
Allows users to:
Select a drive
Choose an image file destination
Start and monitor the imaging process


How It Works:
Select a Physical Drive from the dropdown list (e.g., \\.\PHYSICALDRIVE0).
Browse to choose a destination folder for the image (.img).
Click "Create Disk Image" to start the imaging process.
The app reads the drive sector-by-sector, skipping unreadable sectors and zero-filling them as needed.
Once complete, a log file is saved in the same directory as the image file with a detailed report of the process.

In testing, the application produced images with a hash match to images produced by professional digital forensic tools. 


Example Log File (MyDiskImage.txt):

=== Begin Imaging Log ===

Drive Path: \\.\PHYSICALDRIVE0

Total Bytes (from geometry): 1000204886016

Bytes Per Sector: 512

[ERROR] Sector 1234 read failed: The drive cannot find the sector requested. Zero-filling sector.

Total Sectors: 1953525168

Successful Sectors: 1953525160

Error Sectors: 8

Total Bytes Read: 1000204886016

=== End of Imaging Log ===

Summary of Improvements in the Latest Version:
- More accurate disk size detection using DeviceIoControl.
- Sector-by-sector reading to handle large drives efficiently.
- Error handling and zero-filling for unreadable sectors.
- Detailed logging to provide users with a report of the imaging process.
- Text log file output saved automatically alongside the .img file.
- Progress bar and UI updates for real-time feedback.


WinImager is designed for anyone who needs a basic, reliable and lightweight Windows disk imaging solution. 
