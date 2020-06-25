using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6387)]
    [Attributes(9)]
    public sealed class Gsm1900LinearPaR2VbattHiComp
    {
        public short Value { get; set; }
    }
}