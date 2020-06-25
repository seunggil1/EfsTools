using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00025012", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm850KvCal
    {
        public uint KvCalValue { get; set; }


        public ushort KvCalLowChan { get; set; }


        public ushort KvCalHighChan { get; set; }
    }
}