Password Generator
==================

This is a collection of code that contains a library and several applications for various platforms.  

The primary purpose of this repository is to house these apps, which will be used in a presentation given at Houston Techfest 2011.

Application Versions
--------------------
The library and all the applications are written in C# but are written for their specific platform utilizing Mono and the Mono specific bindings for that platform, for the most part all versions were written on their specific platform as well (notable exceptions being the iPhone and Android versions, they were written on a Mac).

### PasswordGeneratorLib
This is the library source code that powers the other application. It contains the following:

* PasswordGenerator - This is the library project and contains the code for setting the type of password and generating the password.
* PasswordGeneratorTestApp - A simple console app so one can see resulted output of various setting changes to the generator object.
* PasswordGeneratorTests - NUnit test project for the library.

### PasswordGenerator_GTK
This is the GTK version of the application. In other words this is the version written specifically to run on Linux where Mono and GTKSharp is installed. This was written on an Ubuntu Linux 10.04 machine, utilizing the versions of Mono and GTKSharp that come with that specific version of Ubuntu.

### PasswordGenerator-monotouch
The iPhone version of the application. Written on OSX utilizing Monodevelop and XCode 4.

### PasswordGenerator_monodroid
Here you will find the Android version of the application. This was written against Mono for Android 1.9.1 and is built for Android 2.2 (API version 8).

### PasswordGenerator_OSX
This folder contains the OSX application. It utilizes MonoMac bindings to Cocoa objects.

### PasswordGenerator_Win
The Windows version of the application.  Written on a Windows 7 VM using Visual Studio C# Express Edition.