using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6999)]
    [Attributes(9)]
    public sealed class Wcdma1500MaxPwrBackoffVolt1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public short[] Value { get; set; }
    }
}