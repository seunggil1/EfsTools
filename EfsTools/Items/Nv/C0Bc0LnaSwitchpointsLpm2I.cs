using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3277)]
    [Attributes(9)]
    public sealed class C0Bc0LnaSwitchpointsLpm2
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public sbyte[] Value
        {
            get;
        }
    }
}