# EfsTools. Console program for accessing the EFS file system of Qualcomm modems

사용하기 이전에 Dotnet 5.0 버전을 설치하셔야 됩니다.

https://dotnet.microsoft.com/download/dotnet/5.0

1. uploadDirectory
'i', "inComputerPath"
'o', "outEfsPath"
'v', "processNvItems"

2. extractMbn
'i', "inputMbnFilePath"
'p', "outputComputerDirectoryPath"
'n', "noExtraData"

3. "setModemConfig"
'p', "inputComputerFilePath"
'o', "outComputerFilePath"
's', "subscriptionIndex"

The program allows you to:
- Get information about the connected device
- Get information about the parameters of the file system EFS
- Read file from device to computer
- Write file from computer to device
- Delete file from device
- Rename (move) the file on the device
- Create directory in device
- Delete directory on device
- Get a list of files and directories
- Download catalog from device to computer
- Download the catalog from the computer to the device.

## System requirements

- Windows 8.1, Windows 10 1607 or later, Windows Server 2012 R2 or later, Mac OS X 10.13 or later, Red Hat Enterprise Linux 7 or later, CentOS 7 or later, Ubuntu 16.04 or later, Fedora 30 or later, Debian 9 and newer, OpenSUSE 15 and newer
- [DotNetCore 3.1] (https://dotnet.microsoft.com/download/dotnet-core/3.1/runtime) and later.

## Installation
You need to download the release archive from the [developer's site] (http://johnbel.github.io/). Then unzip it.

## Configuration
Program settings are stored in the EfsTools.exe.config file. Before starting work, you must specify the name of the COM port (parameter *** port ***) and its speed (*** baudrate ***).

## Command line parameters

EfsTools.exe <command> [command parameters]

### Command List
  
*** targetInfo ***
Getting information about the connected device.

Example: EfsTools.exe targetInfo

*** efsInfo ***
Retrieving EFS Information on a Device

Example: EfsTools.exe efsInfo

*** readFile ***
Reading a file from a device to a computer

Example: EfsTools.exe readFile -i / safe / test / efs -o c: \ temp \ efs

*** writeFile ***
Writing a file from a computer to the device

Example: EfsTools.exe writeFile -i c: \ temp \ efs -o / safe / test / efs

*** renameFile ***
Rename file on device

Example: EfsTools.exe renameFile -p / safe / test / efs -n / safe / test / efs2


*** deleteFile ***
Delete file on device

Example: EfsTools.exe deleteFile -p / safe / test / efs

*** createDirectory ***
Create directory on device

Example: EfsTools.exe createDirectory -p / safe / test / efs


*** deleteDirectory ***
Delete directory on device

Example: EfsTools.exe deleteDirectory -p / safe / test / efs


*** listDirectory ***
Get a list of files and directories

Example: EfsTools.exe listDirectory -p / safe / test / efs -r

*** downloadDirectory ***
Download catalog from device to computer

Example: EfsTools.exe downloadDirectory -i / -o c: \ backup \ efs


*** uploadDirectory ***
Load catalog from computer to device

Example: EfsTools.exe uploadDirectory -i c: \ backup \ efs -o /


*** getModemConfig ***
Generate modem configuration using device or directory (option -i) with EFS structure

Example: EfsTools.exe getModemConfig -i. \ Backup -p. \ Items_backup.json
EfsTools.exe getModemConfig -p. \ Items_phone.json


*** setModemConfig ***
Set the modem configuration in the device or generate an EFS structure in the directory (-o parameter)

Example: EfsTools.exe setModemConfig -p. \ Items.json -o. \ Efs
EfsTools.exe setModemConfig -p. \ Items_for_phone.json


*** extractMbn ***
Unpack the contents of the MBN (Modem configuration BiNary) file into the specified directory
Example: EfsTools.exe extractMbn -i mcfg_sw.mbn -p mcfg

*** getLog ***
Start capturing modem logs and messages
Example: EfsTools.exe getLog -l IMS_MESSAGE
  
  
*** help ***
Show command help

Example: EfsTools.exe help createDirectory

*** version ***
Show program version

Example: EfsTools.exe version

## Licenses
This software is distributed under the [MIT] license (/ License.md)

The program uses the [Commandline] library (https://github.com/commandlineparser/commandline) Copyright (c) 2005 - 2015 Giacomo Stelluti Scala & Contributors

The program uses the library [Newtonsoft.Json] (https://www.newtonsoft.com/json) Copyright (c) 2007 James Newton-King

The program uses the library [ELFSharp] (http://elfsharp.hellsgate.pl) Copyright (c) Konrad Kruczyński, iotr Zierhoffer, Łukasz Kucharski, Bastian Eicher, Cameron, Fox, Frederik Carlier, Everett Maus

The protocol for working with Qualcomm modems was read in the [libopenpst] project (https://github.com/openpst/libopenpst) Copyright (c) Gassan Idriss

## Website
[JohnBel] (http://johnbel.github.io/)
