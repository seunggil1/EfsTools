using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020485", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaTxLinVsTemp3Mtd
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] Value { get; set; }
    }
}