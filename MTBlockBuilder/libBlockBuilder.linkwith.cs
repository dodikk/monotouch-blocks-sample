using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libBlockBuilder.a", LinkTarget.ArmV7| LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, LinkerFlags="-ObjC -all_load")]
