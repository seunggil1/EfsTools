using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2009)]
    [Attributes(9)]
    public sealed class WcdmaTxLinMaster2
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 37)]
        public ushort[] Value { get; set; }
    }
}