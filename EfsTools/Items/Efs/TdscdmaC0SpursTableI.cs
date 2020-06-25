using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025530", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaC0SpursTable
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public QmslRxSpurTableNvType[] SpurInfo { get; set; }
    }
}