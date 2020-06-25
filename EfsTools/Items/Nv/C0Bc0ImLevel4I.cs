using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1763)]
    [Attributes(9)]
    public sealed class C0Bc0ImLevel4
    {
        public byte Value { get; set; }
    }
}