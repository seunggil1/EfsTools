using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5671)]
    [Attributes(9)]
    public sealed class Gsm900AmpmLinearPaRangebF3Seg1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public short[] Value { get; set; }
    }
}