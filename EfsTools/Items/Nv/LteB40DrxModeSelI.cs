using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6753)]
    [Attributes(9)]
    public sealed class LteB40DrxModeSel
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Value { get; set; }
    }
}