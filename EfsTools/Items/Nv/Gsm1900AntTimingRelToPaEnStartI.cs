using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3069)]
    [Attributes(9)]
    public sealed class Gsm1900AntTimingRelToPaEnStart
    {
        public short Value { get; set; }
    }
}