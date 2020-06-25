using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024975", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm1900TxCalData
    {
        public byte TxCalChanSize { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ushort[] TxCalChan { get; set; }


        public short AmamMaxDbm { get; set; }


        public byte RgiForPred { get; set; }


        public VariantMarker VariantDataMarker { get; set; }
    }
}