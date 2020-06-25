using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7223)]
    [Attributes(9)]
    public sealed class C1Wcdma2100LnaRangeOffset5Car1
    {
        public short Value { get; set; }
    }
}