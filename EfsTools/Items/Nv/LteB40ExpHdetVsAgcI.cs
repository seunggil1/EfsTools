using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6683)]
    [Attributes(9)]
    public sealed class LteB40ExpHdetVsAgc
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] Value { get; set; }
    }
}