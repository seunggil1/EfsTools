using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4984)]
    [Attributes(9)]
    public sealed class Wcdma1800TxCompVsFreqSecPdmList
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] Value { get; set; }
    }
}