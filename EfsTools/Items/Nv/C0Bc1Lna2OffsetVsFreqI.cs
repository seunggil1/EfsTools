using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1651)]
    [Attributes(9)]
    public sealed class C0Bc1Lna2OffsetVsFreq
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public sbyte[] Value
        {
            get;
        }
    }
}