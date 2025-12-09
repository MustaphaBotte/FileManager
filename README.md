# FileManager Application

## Overview

A comprehensive desktop application built with .NET 8 WinForms that provides secure file operations, cryptographic utilities, and password management.
The application implements security best practices while offering a modern, user-friendly interface.

---

## Features

### 1. Password and Key Generation
- Generate strong random passwords (upper/lower case, symbols, or mixed).
- Generate 128-bit cryptographic keys.
- Hash passwords.
- UI for saving passwords, 128-bit keys,and hashes into your local machine.
- Prevents saving weak or modified passwords/keys.

### 2. File Encryption and Decryption
- Encrypt files using a 128-bit key that is generated based on your password.
- AES-128 Encryption/Decryption with password-derived keys.
- Secure Password Hashing with SHA256 plus salting for credential storage


- Decrypt files using the same key.
- You can encrypt all file types.

### 3. File Compression
- Compress multiple and different files into a single ZIP file.
- Progress callback support for monitoring compression progress.

### 4. File Downloading
- Download files from the internet with a custom user-agent.
- Progress callback for download status(progress).
- Automatically detects file type (e.g., PNG, JPG, PDF, ZIP, MP4, etc.) and saves with the correct extension.
- Handles common web file types and some video formats.
- Error handling and user notifications for download issues.
- UI for entering download URLs and selecting download path for each file and start all the operation in the same time, 

### 5. User Interface
- Windows Forms UI for all major features.
- Datagridview user control for reuseability accross forms.
- User feedback for invalid input or errors.
- Modern look and feel using Guna.UI2.WinForms.

### 6. Project Structure and Dependencies
- Targets .NET 8 (net8.0-windows).
- Uses Guna.UI2.WinForms for UI.
- Uses SharpZipLib for compressing.
- Modular design with separate projects for core logic and UI.

---

## Getting Started

- You must have .net8 framework on your machine. 
- Open the solution in Visual Studio 2022 or later.
- Restore NuGet packages and build the solution.
- Run the application to access the UI or use the console for command-line utilities.

---
This project is fully open for customization—modify, extend, and integrate it into your workflow as needed.


