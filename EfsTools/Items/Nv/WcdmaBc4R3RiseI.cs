using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4061)]
    [Attributes(9)]
    public sealed class WcdmaBc4R3Rise
    {
        public ushort Value { get; set; }
    }
}