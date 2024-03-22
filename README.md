# 30 Days Lost in the Wilderness

![](assets/cover.jpg)
Are you a .NET developer?  Are you interested in learning about IoT and embedded programming?  This is the project for you!

This project is a port of the [`inventr.io`](https://inventr.io) series 30 Days Lost in Space, but it assumes you already know how to program in C#.  Even beginners in programming can use these labs to get an understanding of the basics of writing code that affects real-world hardware.

To be clear, this repository and its author are not affiliated with inventr.io at all, and this code is not sponsored or promoted as anything "official."  I simply believe that their content is a great introduction to embedded software development.

This set of labs is not a replacement for the original content, it is purely a supplement.  I encourage you to watch the original videos for each day to get background information as well as explanations on the how and why of component selection and wiring.  The content generated for these labs will simply call out differences based on the hardware used.

Speaking of hardware, the original set of labs use an Arduino board.  This is an unsuitable target for the code we'll be using, so instead we'll replace the main processor board with something else.  However, these labs do use all of the additional hardware - sensors, displays, wires, etc. from the original kit. Since inventr.io spent time, money, and resources generating the original content, I feel it's important to support that effort and to purchase their kit.

## Things You'll Need

For these labs you will need hardware and a development environment.  The content will be using a Windows development machine, but with a little experience, modification, and persistence these will also work on Linux or Mac development machines.

### Hardware

[Start by buying an inventr.io kit](https://inventr.io/products/adventure-kit-30-days-lost-in-space) (again, not sponsored but they did the initial work and deserve the benefit)

Next you'll need a replacement compute module.  This lab will, generally, support two different hardware targets:

The [Wilderness Labs Meadow F7Feather](https://store.wildernesslabs.co/collections/frontpage/products/meadow-f7-feather) is my preferred target.  I do work for Wilderness Labs, but this is not an official product of Wilderness Labs.  That means development and support is provided here, not by Wilderness.
To try to be agnostic to the target, you can also use a [Raspberry Pi Zero 2 W](https://amzn.to/3PAXqjM) if you so choose.


A C# Port of 30 Days Lost in Space (inventr.io)

### Development Tools

If you are using a Meadow F7Feather as your target, you can use Visual Studio 2022 or VS Code.
If you are using a Raspberry Pi as your target, you should use VS Code

### Time

Most of these labs are straightforward and generally should take less than an hour to complete