using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2721)]
    [Attributes(9)]
    public sealed class Wcdma800MaxPwrBackoffVolt1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public short[] Value { get; set; }
    }
}