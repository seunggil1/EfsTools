using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4331)]
    [Attributes(9)]
    public sealed class C1Bc15Im2IValue
    {
        public byte Value { get; set; }
    }
}