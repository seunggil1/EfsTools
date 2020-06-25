using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1536)]
    [Attributes(9)]
    public sealed class C1Bc4Lna2Fall
    {
        public sbyte Value { get; set; }
    }
}