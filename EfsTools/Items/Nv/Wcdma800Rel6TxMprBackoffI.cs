using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4949)]
    [Attributes(9)]
    public sealed class Wcdma800Rel6TxMprBackoff
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public byte[] Value { get; set; }
    }
}