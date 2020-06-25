using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(410)]
    [Attributes(9)]
    public sealed class PaRangeOffsets
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public short[] Value { get; set; }
    }
}