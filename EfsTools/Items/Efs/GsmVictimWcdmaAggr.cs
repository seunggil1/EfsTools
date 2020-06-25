using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/mcs/lmtsmgr/coex/blank/gsm_victim_wcdma_aggr", false, 0x81FF)]
    [Attributes(9)]
    public sealed class GsmVictimWcdmaAggr
    {
    }
}