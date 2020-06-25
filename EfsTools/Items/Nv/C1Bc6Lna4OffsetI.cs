using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1250)]
    [Attributes(9)]
    public sealed class C1Bc6Lna4Offset
    {
        public short Value { get; set; }
    }
}