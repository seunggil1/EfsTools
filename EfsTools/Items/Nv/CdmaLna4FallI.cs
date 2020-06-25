using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(598)]
    [Attributes(9)]
    public sealed class CdmaLna4Fall
    {
        public sbyte Value { get; set; }
    }
}