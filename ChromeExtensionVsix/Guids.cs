// Guids.cs
// MUST match guids.h
using System;

namespace LigerShark.ChromeExtensionVsix
{
    static class GuidList
    {
        public const string guidChromeExtensionVsixPkgString = "a03c618e-fb2c-4273-b7f3-182bedb0164d";
        public const string guidChromeExtensionVsixCmdSetString = "326aa9f0-1952-4a17-84cc-ebdecc86463d";

        public static readonly Guid guidChromeExtensionVsixCmdSet = new Guid(guidChromeExtensionVsixCmdSetString);
    };
}