# KeePassFingerprint

- Keepass v2.36 32\64bit fingerprint plugin.

# Technology used:

  - Windows Biometric Framework using WinBioNET c# wrapper
  - DPAPI to crypt\encrypt encrypt sensitive data

# Compile & Install:

In order to compile you have to use Visual Studio 2017 Comunity Edition.
The binary produced works only with the Keepass version used as reference and present on "ext" folder.

To install on Keepass, you have to copy the following files into "KeePass Password Safe 2\Plugins" folder:
  - EnrollCapture.exe
  - FingerprintPlugin.dll
  - Newtonsoft.Json.dll
  - WinBioNET.dll

# Use:

The first time open the keepass database with MasterPassword. 
Now on Tools Menù is present a new item "Fingerprint".
After you select fingerprint a new window is opened.
The first time you have to Initialize the Unit with the related button.
After that you can set the MasterPassword on the textbox.
The password is saved locally crypted with DPAPI.

Now when you open Keepass you have to deselect MasterPassword checkbox and select "Key File" with "Fingerprint Key Provider" as provider.
