using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(567)]
    [Attributes(9)]
    public sealed class TestCodeVer
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] Value { get; set; }
    }
}