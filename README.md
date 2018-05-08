# Hololens.DevicePortal Apis
Simple C# project that accesses the Hololens Device portal REST APIs.

This project is essentially dead for the time being. I started it up when early documentation and tooling for the Hololens was limited or not yet complete. But, that issue has been resolved since I started this. I essentially abandoned this project when I saw MS was creating the same thing (https://github.com/Microsoft/WindowsDevicePortalWrapper).

## Quick summary:
The Hololens has a built-in interface (Device Portal) that is accessible by a browser. Using the excellent [Charles Reverse Proxy](https://www.charlesproxy.com/documentation/welcome/), I had scraped the HTTPS calls/payloads that were being made from the browser to the Hololens. Reverse engineering from that, we have this C# library that essentially worked as the browser would have, and does the HTTP calls itself. The final goal was to allow cross-platform C# applications to remotely control a Hololens, or to pull data in real-time from one or more Hololens devices.

The API surface of this library is rough, as I tried to mimic the HTTPS paths directly in how the C# class heirarchy is laid out. The plan was for a cleaner API to come in later.
There is a decent amount of reverse engineering done on some of the 3d primitives, so that might be of some interest to folks. As well as a handful of JSON.Net JsonConverters for some of the JSON payloads.

This is not complete, nor can I vouch for what is there actually working anymore.
