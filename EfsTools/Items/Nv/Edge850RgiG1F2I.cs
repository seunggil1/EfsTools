using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5485)]
    [Attributes(9)]
    public sealed class Edge850RgiG1F2
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] Value { get; set; }
    }
}