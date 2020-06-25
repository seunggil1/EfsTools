using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6702)]
    [Attributes(9)]
    public sealed class LteB1ImLevel
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public short[] Value { get; set; }
    }
}