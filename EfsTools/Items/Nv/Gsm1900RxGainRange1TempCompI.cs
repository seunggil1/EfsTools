using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4376)]
    [Attributes(9)]
    public sealed class Gsm1900RxGainRange1TempComp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public short[] Value { get; set; }
    }
}