using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6499)]
    [Attributes(9)]
    public sealed class LteB13Im2Values
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Value { get; set; }
    }
}