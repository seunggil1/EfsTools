using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5589)]
    [Attributes(9)]
    public sealed class C0Bc12Im2Cal
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public byte[] Value
        {
            get;
        }
    }
}