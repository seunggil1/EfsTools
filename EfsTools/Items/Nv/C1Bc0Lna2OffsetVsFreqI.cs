using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1767)]
    [Attributes(9)]
    public sealed class C1Bc0Lna2OffsetVsFreq
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public sbyte[] Value
        {
            get;
        }
    }
}