using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5126)]
    [Attributes(9)]
    public sealed class Bc15P3RiseFallOff
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] Value
        {
            get;
        }
    }
}