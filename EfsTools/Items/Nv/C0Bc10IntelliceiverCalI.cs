using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5239)]
    [Attributes(9)]
    public sealed class C0Bc10IntelliceiverCal
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public ushort[] Value
        {
            get;
        }
    }
}