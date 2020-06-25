using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5226)]
    [Attributes(9)]
    public sealed class C0Bc10Lna2Fall
    {
        public sbyte Value { get; set; }
    }
}