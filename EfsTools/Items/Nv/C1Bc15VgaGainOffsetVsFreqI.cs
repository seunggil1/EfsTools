using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4334)]
    [Attributes(9)]
    public sealed class C1Bc15VgaGainOffsetVsFreq
    {
        public sbyte[] Value { get; set; }
    }
}