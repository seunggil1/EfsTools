using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025034", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm1800SarBackoff
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot1 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot2 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot3 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot4 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot5 { get; set; }
    }
}