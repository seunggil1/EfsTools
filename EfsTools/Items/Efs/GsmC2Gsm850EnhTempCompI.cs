using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025112", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm850EnhTempComp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public short[] TempcompTable { get; set; }
    }
}