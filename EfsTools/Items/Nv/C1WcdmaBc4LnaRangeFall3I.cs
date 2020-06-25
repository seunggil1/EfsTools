using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4501)]
    [Attributes(9)]
    public sealed class C1WcdmaBc4LnaRangeFall3
    {
        public short Value { get; set; }
    }
}