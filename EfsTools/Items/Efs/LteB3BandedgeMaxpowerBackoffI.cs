using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025189", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB3BandedgeMaxpowerBackoff
    {
        public byte Enable { get; set; }


        public byte LowerbandBackoff { get; set; }


        public byte UpperbandBackoff { get; set; }
    }
}