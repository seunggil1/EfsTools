using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1102)]
    [Attributes(9)]
    public sealed class Gsm850RxGainRange1FreqComp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] Value { get; set; }
    }
}