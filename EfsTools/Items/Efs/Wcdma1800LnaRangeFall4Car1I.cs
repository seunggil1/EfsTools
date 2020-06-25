using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023799", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma1800LnaRangeFall4Car1
    {
        public short Value { get; set; }
    }
}