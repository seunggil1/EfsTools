using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2380)]
    [Attributes(9)]
    public sealed class DcsVhTlPrdi15
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public byte[] Value { get; set; }
    }
}