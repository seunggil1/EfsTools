using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00021970", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc6TxPwrFreqComp0
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public sbyte[] Value { get; set; }
    }
}