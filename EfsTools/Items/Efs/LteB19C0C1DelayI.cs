using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00023119", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB19C0C1Delay
    {
        public sbyte Value { get; set; }
    }
}