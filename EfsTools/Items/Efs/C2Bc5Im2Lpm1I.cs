using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00021893", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2Bc5Im2Lpm1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Value
        {
            get;
        }
    }
}