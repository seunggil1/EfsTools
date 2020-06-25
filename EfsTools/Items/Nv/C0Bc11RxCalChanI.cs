using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3877)]
    [Attributes(9)]
    public sealed class C0Bc11RxCalChan
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] Value
        {
            get;
        }
    }
}