using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2748)]
    [Attributes(9)]
    public sealed class Gsm1900AutocalPwrDacF1
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }
}