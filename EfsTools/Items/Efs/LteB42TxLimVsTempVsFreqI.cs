using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024582", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB42TxLimVsTempVsFreq
    {
        public byte MatrixEnabled { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public sbyte[] LimVsTempVsFreq { get; set; }
    }
}