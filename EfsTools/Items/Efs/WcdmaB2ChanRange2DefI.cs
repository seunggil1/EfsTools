using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022429", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB2ChanRange2Def
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ushort[] Value { get; set; }
    }
}