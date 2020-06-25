using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021017", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB2PaSmpsGstTemp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public short[] Value { get; set; }
    }
}