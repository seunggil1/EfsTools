using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4169)]
    [Attributes(9)]
    public sealed class Wcdma800Iaccum
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] Value { get; set; }
    }
}