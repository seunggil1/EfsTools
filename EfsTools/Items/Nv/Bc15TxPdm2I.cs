using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4829)]
    [Attributes(9)]
    public sealed class Bc15TxPdm2
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public short[] Value
        {
            get;
        }
    }
}