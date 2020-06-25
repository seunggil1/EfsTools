using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/mcs/lmtsmgr/coex/backoff/non_im_desense_gsm_victim_lte_aggr", false, 0x81FF)]
    [Attributes(9)]
    public sealed class NonImDesenseGsmVictimLteAggr
    {
    }
}