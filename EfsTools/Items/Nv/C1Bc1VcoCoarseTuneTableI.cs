using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1899)]
    [Attributes(9)]
    public sealed class C1Bc1VcoCoarseTuneTable
    {
        public byte[] Value { get; set; }
    }
}