using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/hdr/mac/hdr_dtx_cfg", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class HdrDtxCfg
    {
        public ushort Value { get; set; }
    }
}