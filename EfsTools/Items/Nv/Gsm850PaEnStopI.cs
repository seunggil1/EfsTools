using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3074)]
    [Attributes(9)]
    public sealed class Gsm850PaEnStop
    {
        public short Value { get; set; }
    }
}