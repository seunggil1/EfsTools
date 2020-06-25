using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(911)]
    [Attributes(9)]
    public sealed class GprsMultiSlotClass
    {
        public byte Value { get; set; }
    }
}