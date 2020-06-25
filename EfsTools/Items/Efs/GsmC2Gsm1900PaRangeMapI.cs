using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025433", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm1900PaRangeMap
    {
        public byte PaRangeMap { get; set; }
    }
}