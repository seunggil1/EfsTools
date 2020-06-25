using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6123)]
    [Attributes(9)]
    public sealed class C1BcxBlock1Lna2Fall
    {
        public sbyte Value { get; set; }
    }
}