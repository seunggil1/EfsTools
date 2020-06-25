using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(589)]
    [Attributes(9)]
    public sealed class TxGainAttenLimit
    {
        public short Value { get; set; }
    }
}