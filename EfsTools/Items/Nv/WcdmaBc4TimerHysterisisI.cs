using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5050)]
    [Attributes(9)]
    public sealed class WcdmaBc4TimerHysterisis
    {
        public short Value { get; set; }
    }
}