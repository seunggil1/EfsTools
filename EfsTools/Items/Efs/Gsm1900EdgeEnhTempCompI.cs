using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024605", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Gsm1900EdgeEnhTempComp
    {
        public GsmEnhtempcompTempType Value { get; set; }
    }
}