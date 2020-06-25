using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5932)]
    [Attributes(9)]
    public sealed class C1Wcdma2100RxfIciICoef89
    {
        public uint Value { get; set; }
    }
}