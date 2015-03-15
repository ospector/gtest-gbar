# Introduction #
This project is an independent addition for [googletest](http://code.google.com/p/googletest/).


Google Test is an excellent xUnit style c++ unit testing framework. It is highly recommended. One (minor) drawback of Google Test is it's text based UI, and this project attempts to help.

# Deliverables #
This project is a standalone .Net 2.0 executable which displays a UI for a Google Test based harness with the following elements:
  1. A progress bar which is either green or red, according to test success
  1. A list of all failures and their details upon click
The UI saves a history of several runs (configurable), allows command line parameters to be passed to the test program and gives convenient access to the following google test features:
  * filtering tests
  * forcing execution of disabled tests
  * shuffling tests

The project runs on both Windows and Linux (under Mono). Here are some [ScreenShots](ScreenShots.md).

# Installation #
  1. Download the ZIP
  1. Open it somewhere other than "Program Files"
If you insist on "Program Files", then you will need to run this with Administrative rights.

# Version History #
See [VersionHistory](VersionHistory.md)

# FAQ #
## Why isn't this a plug-in for my favorite IDE ##
I didn't want to bother writing several plug-in's. Actually I didn't even want to write one. I find that a standalone app that I run constantly as I code is very convenient, and I am not limited to VS 2005/2008/2010, Eclipse, etc.
## So how do you recommend I use this ##
  1. Fire up your IDE
  1. Run the app (called "Guitar" - you can work out the acronym)
  1. In app main dialog select your test executable
  1. Press "Go" whenever your tests/code compile (TDDers, note the order ;-) )
Note 1: the test executable should (of course) be a google test executable. The application parses google test stdout.

Note 2:The application remembers the last executable run between sessions.
## I cant open SLN/Proj files ##
You are probably on an older VS version. Don't worry - project is dead simple. Just roll up your own and add all files.


Enjoy.

Omri.