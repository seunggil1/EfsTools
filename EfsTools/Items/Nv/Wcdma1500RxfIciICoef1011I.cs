using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7035)]
    [Attributes(9)]
    public sealed class Wcdma1500RxfIciICoef1011
    {
        public uint Value { get; set; }
    }
}