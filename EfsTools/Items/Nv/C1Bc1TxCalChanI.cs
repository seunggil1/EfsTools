using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1685)]
    [Attributes(9)]
    public sealed class C1Bc1TxCalChan
    {
        public ushort[] Value { get; set; }
    }
}