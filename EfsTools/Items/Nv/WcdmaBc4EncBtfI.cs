using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4041)]
    [Attributes(9)]
    public sealed class WcdmaBc4EncBtf
    {
        public int Value { get; set; }
    }
}