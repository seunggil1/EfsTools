using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6393)]
    [Attributes(9)]
    public sealed class C1Wcdma1800RxfMisCompBCoeff
    {
        public short Value { get; set; }
    }
}