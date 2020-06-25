using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(662)]
    [Attributes(9)]
    public sealed class GpsDaccIaccum4
    {
        public byte Value { get; set; }
    }
}