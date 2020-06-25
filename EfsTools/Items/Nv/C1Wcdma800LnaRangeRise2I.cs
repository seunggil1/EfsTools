using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3823)]
    [Attributes(9)]
    public sealed class C1Wcdma800LnaRangeRise2
    {
        public ushort Value { get; set; }
    }
}