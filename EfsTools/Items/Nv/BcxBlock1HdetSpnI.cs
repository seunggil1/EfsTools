using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6073)]
    [Attributes(9)]
    public sealed class BcxBlock1HdetSpn
    {
        public byte Value { get; set; }
    }
}