using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00023754", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC31xSpurTable
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public QmslRxSpurTableNvType[] SpurInfo { get; set; }
    }
}