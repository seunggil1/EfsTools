using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00020736", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class T900AptCharTblPout0
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public short[] Value { get; set; }
    }
}