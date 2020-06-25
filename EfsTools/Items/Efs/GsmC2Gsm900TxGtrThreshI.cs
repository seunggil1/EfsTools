using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025105", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm900TxGtrThresh
    {
        public GsmTxGtrThreshDataType GtrThresh { get; set; }
    }
}