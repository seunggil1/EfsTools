using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025007", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm1900EnvGain
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ushort[] EnvGainFreqRgiF1 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ushort[] EnvGainFreqRgiF2 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ushort[] EnvGainFreqRgiF3 { get; set; }
    }
}