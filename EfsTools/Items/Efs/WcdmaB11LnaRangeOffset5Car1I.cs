using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022570", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class WcdmaB11LnaRangeOffset5Car1
    {
        public short Value { get; set; }
    }
}