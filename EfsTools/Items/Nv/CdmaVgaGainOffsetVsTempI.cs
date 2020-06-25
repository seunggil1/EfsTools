using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(699)]
    [Attributes(9)]
    public sealed class CdmaVgaGainOffsetVsTemp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public short[] Value { get; set; }
    }
}