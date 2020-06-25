using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3796)]
    [Attributes(9)]
    public sealed class C1Wcdma1900LnaRangeFall
    {
        public short Value { get; set; }
    }
}