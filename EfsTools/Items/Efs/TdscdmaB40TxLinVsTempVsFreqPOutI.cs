using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025730", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class TdscdmaB40TxLinVsTempVsFreqPOut
    {
        public byte Reserved { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }
}