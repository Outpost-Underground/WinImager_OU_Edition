The WinImager utility with a custom skin. 

WinImager - Disk Imaging Utility (v1.0)

## Overview

WinImager is a **Windows application** designed to create an **exact, sector-by-sector copy** (an “image”) of any selected physical drive. It is particularly useful for:

- **Data Recovery**: Safely copying data from failing or aging drives before they completely fail.  
- **Digital Forensics**: Generating a **forensically sound** image of a drive, along with optional integrity checks (MD5 & SHA1).

The app reads an entire drive in user-defined “chunks,” can operate in a “Gentle Mode” to minimize strain on fragile drives, and can compute **MD5/SHA1 hashes** to verify the final image accurately represents the source data.

---

## Key Features

1. **Physical Drive Enumeration**  
   - Lists all recognized physical disks (e.g., `\\.\PhysicalDrive0`) via Windows Management Instrumentation (WMI).  
   - Displays each drive’s reported size in gigabytes (GB).

2. **Accurate Geometry & Raw Copy**  
   - Uses **DeviceIoControl (IOCTL_DISK_GET_DRIVE_GEOMETRY_EX)** to detect the drive’s **true size** and sector information.  
   - Creates a **bit-for-bit** copy (including hidden and system areas), ensuring data integrity and completeness.

3. **Robust Error Handling**  
   - Automatically **zero-fills** any unreadable chunk.  
   - Records partial reads or errors in a detailed **log file**.

4. **Gentle Mode**  
   - Slows down the imaging process with small pauses, reducing stress on old or physically fragile hard drives.

5. **User-Defined “Chunk” Size**  
   - Choose how many megabytes WinImager reads at once. Typically 4 MB for modern drives.  
   - Larger chunks (8+ MB) can speed up imaging on fast USB 3.1+ SSDs.  
   - Smaller chunks (1 MB or less) may help on problematic or older hardware.

6. **Optional MD5 & SHA1 Hashing**  
   - After imaging, WinImager can re-read the newly created `.img` file to confirm it matches what was read from the source drive.  
   - This provides **cryptographic assurance** that the image file is accurate and unaltered.

7. **Drive Metadata in the Log**  
   - Pulls **Model** and **Serial Number** from the drive (via WMI).  
   - Logs the **start/end times** of imaging and hashing, plus total elapsed time.

8. **Detailed Text Log**  
   - Automatically creates a `.txt` file next to your `.img` file, containing:  
     - Source drive path, model, serial  
     - Imaging start/end times, chunk settings, error counts  
     - (If enabled) MD5 & SHA1 values for source data vs. final image

---

## Use Cases

1. **Data Recovery**  
   - Copy data from a partially failing drive, zero-filling unreadable areas.  
   - Use Gentle Mode if the drive is old or making unusual noises.

2. **Forensic Imaging**  
   - Make a reliable copy of a suspect’s drive (or a device under investigation).  
   - Enable MD5/SHA1 to confirm no data discrepancy.  
   - Record drive model/serial and imaging timestamps in the log for an audit trail.

3. **Cloning & Backup**  
   - Create an **exact backup** of a disk, preserving all partitions and boot info.  
   - Keep the log for reference, so you know if any sectors were problematic.

---

## How to Use WinImager

1. **Run as Administrator**  
   - Right-click `WinImager.exe` → “Run as administrator.”  

2. **Select Source Drive**  
   - Pick the drive from the dropdown (`\\.\PhysicalDrive0`, etc.).  
   - Confirm you’ve identified the correct drive.

3. **Browse for Destination**  
   - Choose a folder and `.img` file name (ensure adequate free space).

4. **Adjust Settings**  
   - **Chunk (MB)**: Typically set 4 MB for standard usage. Increase for speed if you have a very fast device, or decrease if you see errors.  
   - **Gentle Mode**: Check if the drive is in bad shape (failing, mechanical noises).  
   - **Compute MD5 & SHA1**: Check if you want a thorough verification.

5. **Click “Create Disk Image”**  
   - Watch the **first progress bar** for imaging progress, and a **second** progress bar for hashing (if enabled).  

6. **Review Results**  
   - After completion, a `.txt` file will be created next to your `.img` with detailed logs:  
     - Model/Serial, chunk size, errors, start/end times, optional hashing results.

---

## Best Practices

- **Ensure Enough Space**: The destination disk/folder must have space at least equal to the source drive’s capacity.  
- **Gentle Mode** for Failing Drives: Slows throughput slightly, helping avoid additional strain.  
- **Hashing**: Use MD5 & SHA1 if you need **proof** of data integrity (common in forensic contexts).  
- **Chunk Size**: 4 MB is a solid default. Larger sizes improve speed on high-speed hardware. Smaller sizes may help if errors arise.  
- **Log File**: Keep or rename the `.txt` log for reference or forensic documentation.

---

## Technical Notes

- **Works** on Windows with .NET (supports .NET Framework or modern .NET versions with WinForms).  
- **Access** raw physical drives → requires **administrator privileges**.  
- **Zero-Fill** unreadable chunks → preserves the file’s correct size (so the `.img` equals the entire drive capacity).  
- **Model & Serial** retrieval depends on WMI availability; some drives may not provide or may partially provide these fields.  
- If **hashing** is enabled, WinImager re-reads the final `.img` file to confirm it matches the data that was read from the drive—ensuring a cryptographic-level guarantee of accuracy.
