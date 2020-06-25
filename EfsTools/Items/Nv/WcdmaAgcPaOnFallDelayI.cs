using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1197)]
    [Attributes(9)]
    public sealed class WcdmaAgcPaOnFallDelay
    {
        public ushort Value { get; set; }
    }
}