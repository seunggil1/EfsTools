using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1679)]
    [Attributes(9)]
    public sealed class C0Bc1Lna4Rise
    {
        public sbyte Value { get; set; }
    }
}