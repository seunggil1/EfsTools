using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6818)]
    [Attributes(9)]
    public sealed class LteB13TxMismatchComp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public short[] Value { get; set; }
    }
}