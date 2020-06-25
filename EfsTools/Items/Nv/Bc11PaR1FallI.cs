using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3865)]
    [Attributes(9)]
    public sealed class Bc11PaR1Fall
    {
        public byte Value { get; set; }
    }
}