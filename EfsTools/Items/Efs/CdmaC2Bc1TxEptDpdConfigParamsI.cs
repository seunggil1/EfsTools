using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00024151", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc1TxEptDpdConfigParams
    {
        public TxXptDpdConfigParamsDataType XptCfgParams { get; set; }
    }
}