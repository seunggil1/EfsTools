using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3857)]
    [Attributes(9)]
    public sealed class Bc11TxLinMaster2
    {
        public short Value1 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 37)]
        public byte[] Value2
        {
            get;
        }
    }
}