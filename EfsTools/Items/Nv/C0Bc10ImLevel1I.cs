using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5231)]
    [Attributes(9)]
    public sealed class C0Bc10ImLevel1
    {
        public byte Value { get; set; }
    }
}