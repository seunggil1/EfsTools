using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6036)]
    [Attributes(9)]
    public sealed class C1Wcdma800RxfIciICoef1213
    {
        public uint Value { get; set; }
    }
}