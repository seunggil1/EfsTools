using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00023902", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB12TxMultiLinV2Data
    {
        public QmslTxCalCompleteRev2NvType Value { get; set; }
    }
}