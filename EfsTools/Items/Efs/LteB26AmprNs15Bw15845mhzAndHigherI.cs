using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024821", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB26AmprNs15Bw15845mhzAndHigher
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Value { get; set; }
    }
}