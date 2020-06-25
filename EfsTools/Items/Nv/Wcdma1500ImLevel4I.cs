using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7010)]
    [Attributes(9)]
    public sealed class Wcdma1500ImLevel4
    {
        public short Value { get; set; }
    }
}