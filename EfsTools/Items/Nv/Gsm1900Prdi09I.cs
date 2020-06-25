using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2154)]
    [Attributes(9)]
    public sealed class Gsm1900Prdi09
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public byte[] Value { get; set; }
    }
}