using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025636", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB6TxLinVsTempVsFreqPOut
    {
        public byte Enabled { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }
}