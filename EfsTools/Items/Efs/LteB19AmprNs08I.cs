using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024804", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB19AmprNs08
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Value { get; set; }
    }
}