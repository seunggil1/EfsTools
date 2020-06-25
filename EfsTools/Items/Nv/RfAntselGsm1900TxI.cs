using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1952)]
    [Attributes(9)]
    public sealed class RfAntselGsm1900Tx
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Value { get; set; }
    }
}