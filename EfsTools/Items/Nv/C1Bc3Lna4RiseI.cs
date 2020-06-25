using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1618)]
    [Attributes(9)]
    public sealed class C1Bc3Lna4Rise
    {
        public sbyte Value { get; set; }
    }
}