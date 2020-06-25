using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4218)]
    [Attributes(9)]
    public sealed class Gsm850PathDelayColdTempVsFreq
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] Value { get; set; }
    }
}