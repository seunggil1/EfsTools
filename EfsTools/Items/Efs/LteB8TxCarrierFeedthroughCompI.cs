using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00020900", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB8TxCarrierFeedthroughComp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public short[] Value { get; set; }
    }
}