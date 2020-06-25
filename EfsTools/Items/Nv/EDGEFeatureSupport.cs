using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2508)]
    [Attributes(9)]
    public sealed class EdgeFeatureSupport
    {
        public byte Value { get; set; }
    }
}