using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(819)]
    [Attributes(9)]
    public sealed class GsmPaStartTimeOffset
    {
        public sbyte Value { get; set; }
    }
}