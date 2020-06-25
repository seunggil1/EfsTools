using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6224)]
    [Attributes(9)]
    public sealed class Bc5SubclassMask
    {
        public uint Value { get; set; }
    }
}