using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025390", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB40C2RxGain
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public short[] Value { get; set; }
    }
}