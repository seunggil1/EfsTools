using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3133)]
    [Attributes(9)]
    public sealed class Gsm850AmpmMasterTblSeg8F3
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public uint[] Value { get; set; }
    }
}