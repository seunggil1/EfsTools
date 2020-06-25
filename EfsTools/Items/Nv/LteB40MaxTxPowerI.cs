using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6658)]
    [Attributes(9)]
    public sealed class LteB40MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}