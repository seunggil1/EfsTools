using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5241)]
    [Attributes(9)]
    public sealed class C1Bc10TxCalChan
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] Value
        {
            get;
        }
    }
}