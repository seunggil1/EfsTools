using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5235)]
    [Attributes(9)]
    public sealed class C0Bc10LnaSwitchpointsLpm1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public sbyte[] Value
        {
            get;
        }
    }
}