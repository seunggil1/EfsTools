using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4390)]
    [Attributes(9)]
    public sealed class GsmRxGainRange5TempComp
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public short[] Value { get; set; }
    }
}