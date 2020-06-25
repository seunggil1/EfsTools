using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4152)]
    [Attributes(9)]
    public sealed class Dcs8pskMultislot5TxPower
    {
        public short Value { get; set; }
    }
}