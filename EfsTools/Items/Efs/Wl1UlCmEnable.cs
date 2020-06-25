using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/nv/item_files/wcdma/cm/wl1_ul_cm_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wl1UlCmEnable
    {
        public byte Value { get; set; }
    }
}