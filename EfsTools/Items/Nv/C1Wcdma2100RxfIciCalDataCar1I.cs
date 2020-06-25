using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7151)]
    [Attributes(9)]
    public sealed class C1Wcdma2100RxfIciCalDataCar1
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
        public uint[] Value { get; set; }
    }
}