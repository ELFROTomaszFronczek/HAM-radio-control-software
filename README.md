A C# simple example of controlling an amateur radio.
Requires Omnirig software to work

<img src="Pictures/snapshot1.png" />

The program consists of two modules
<h2> CAMERA </h2>

This is a radio screen preview module.
If the radio has a monitor output, it can be connected via a special grabber module. Then the image from the radio is seen as a camera and can be displayed in a computer window.
The right mouse button opens the menu.

<h2> Omnirig CAT </h2>

An example of a simple radio control program. Requires omnirig to be installed. It allows you to change the frequency, mode, and the ability to transmit.
link to dxAtlas omnirig: https://www.dxatlas.com/omnirig/

Program tested on Yaesu FTDX101D.
Basic functions work with most radios that Omnirig works with.
Also tested on Icom705 (except functions for Yaesu).
For proper operation, Icom requires appropriate port settings in the radio menu.


- Automatic NTP clock synchronize
- Program can work with frequency offset (ex.for sattelite transmisions)
- Added TRX custom commands controll based on Yaesu manuals.
- Added POTA/SOTA/WWFF/DXCluster program window. You can use frequencies directly from POTA etc. spots and activations(by double click on grid row). Callsign is copied to clipboard.
- Added QRZ.com queries and country detection by callsign.
- Added "doppler module" this is an experimental module that changes frequency over time (ex.for sattelite transmisions). I'm not sure if this is a sensible solution.


<hr/>

I am providing these modules with source code in C# enyoy.

Tomasz Fronczek SP4THK  tomek (at) elfro.pl
