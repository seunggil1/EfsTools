using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3075)]
    [Attributes(9)]
    public sealed class Gsm850AntTimingRelToPaEnStop
    {
        public short Value { get; set; }
    }
}