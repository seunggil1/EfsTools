using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025304", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB11C2RxGainVsFreq
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public sbyte[] Value { get; set; }
    }
}