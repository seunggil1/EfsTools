using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5584)]
    [Attributes(9)]
    public sealed class C0Bc7Im2Cal
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public byte[] Value
        {
            get;
        }
    }
}