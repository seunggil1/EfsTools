using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2643)]
    [Attributes(9)]
    public sealed class Gsm1900AmpmMasterTblSeg3F2
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public uint[] Value { get; set; }
    }
}