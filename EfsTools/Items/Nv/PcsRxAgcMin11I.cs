using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(397)]
    [Attributes(9)]
    public sealed class PcsRxAgcMin11
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Value { get; set; }
    }
}