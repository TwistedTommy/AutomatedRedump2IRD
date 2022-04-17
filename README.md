# @AutomatedRedump2IRD
### The Original Automated IRD Builder
## About
Automated Redump 2 IRD, or AR2I is The Original Automated IRD Builder.  
  
Automated Redump 2 IRD builds all the IRDs for all of the ISO files and Zipped ISO files in a directory recursively, using information from an SQLite DB.  
  
IRDs cannot be built for ROMs with nonmatching titles. Please use a ROM manager to rename your ROMs to match the correct title in the DB.  
  
IRDs are named using the MD5 hash value of the Redump ISO, enabling you to colect the IRDs in the IRDs folder.
## Dependencies
.Net Framework 4  
  
The following NuGet Packages are required to build a Debug and/or Release version of this app:  
- System.Data.SQLite.Core
  
This app does not ship with the following necessary IsoTools Libraries, which are distributed with IsoTools.
- DiscUtils.dll
- Ionic.Zip.dll
- IsoTools.Common.dll
- Microsoft.CompilerServices.AsyncTargetingPack.Net4.dll
  
Place these libraries in the AutomatedRedump2IRD/Resources/Libs/IsoTools.1.34.9 project folder.  
  
IsoTools appears to have been discontinued. We do not know where to find the necessary libraries.  
## Projects
- AutomatedRedump2IRD - Windows Forms App
- AutomatedRedump2IRDRelease - Release Project
## How to Build IRDs
- If you have an account at The Ultimate IRD Database [http://tuid.mygamesonline.org](http://tuid.mygamesonline.org "The Ultimate IRD Database"), set your username and password by editing the Options from the GUI. This will allow you to send IRDs to the database.
- Rename your ROMs using a ROM manager to match the Redump DB you are using.
- Place your Redump DB file in the DB directory, or set the path to it.
- Set the other paths and options as needed.
- Click one of the Build IRDs buttons.
## Contributing
Let's work better together. We are looking to collaborate with like-minded people who want to contribute in any capacity. Collaboration is open to everyone and we need your help if you are a:  
- Collector
- Database Administrator
- Datter
- Developer
- Dumper
- Graphic Artist
- Linguist/Translator
- Player
- Tester
## Contact
GitHub: [https://github.com/TwistedTommy/AutomatedRedump2IRD](https://github.com/TwistedTommy/AutomatedRedump2IRD "GitHub")  
## Disclaimer
We do not upload, share, distribute or provide links to anything illegal, including ROMs or patches.
###### Copyright (c) 2016-2022 Automated Redump 2 IRD - All Rights Reserved v2022-04-16-00
