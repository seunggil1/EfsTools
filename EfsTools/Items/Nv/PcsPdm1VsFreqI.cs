using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(344)]
    [Attributes(9)]
    public sealed class PcsPdm1VsFreq
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public sbyte[] Value { get; set; }
    }
}