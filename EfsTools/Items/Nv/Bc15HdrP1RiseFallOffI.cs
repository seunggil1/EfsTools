using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4292)]
    [Attributes(9)]
    public sealed class Bc15HdrP1RiseFallOff
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Value
        {
            get;
        }
    }
}