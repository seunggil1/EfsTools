using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5505)]
    [Attributes(9)]
    public sealed class Edge1800RgiG1F1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] Value { get; set; }
    }
}