using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7013)]
    [Attributes(9)]
    public sealed class Wcdma1500LnaRangeOffset4
    {
        public short Value { get; set; }
    }
}