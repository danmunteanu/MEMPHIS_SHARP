## Overview

**MemphisSharp** is a tool to help renaming mp3 files in a visual way.

The basic idea is this: 
- **Add a folder** with music files (mp3 only for now)
- **Click on a file** from the list on the left
- The **file name** is **broken down** into **tokens**
- You can **edit each token** and *transform* it to your will

The neat part? The app supports a ***transforms*** engine to automate renaming multiple files at once.
Simply define and configure transforms using the configurator the right hand side.

***App is under (eternal?) development**.* 

And might never be ready. 

Why?

Well, this is a C# port of a previous app I developed in 2015, using C++ and Qt5.

I'm not that motivated to fully develop it, since the idea is kind of old. I'm more interested in growing the underlying automation framework (RealityFrameworks).

All in all, this is a good exercise and stress-test for the above-mentioned framework.

Alright, if you stumble upon this code and find any part of it interesting, do what you want with it. 

No guarantees, though.

## Tech stack:
- C#
- .NET 8.0 (or was it 9.0?)
- WindowsForms - good ol' WindowsForms
- Msagl - library for displaying graphs

![[memphis_sharp.png]]

