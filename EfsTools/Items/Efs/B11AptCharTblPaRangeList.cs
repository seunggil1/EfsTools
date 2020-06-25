using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00022591", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class B11AptCharTblPaRangeList
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Value
        {
            get;
        }
    }
}