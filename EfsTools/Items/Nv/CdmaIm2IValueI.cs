using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(687)]
    [Attributes(9)]
    public sealed class CdmaIm2IValue
    {
        public byte Value { get; set; }
    }
}