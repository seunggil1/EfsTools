using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6734)]
    [Attributes(9)]
    public sealed class LteB1TxCompVsFreq
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public sbyte[] Value { get; set; }
    }
}