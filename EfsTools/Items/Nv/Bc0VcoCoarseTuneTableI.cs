using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1735)]
    [Attributes(9)]
    public sealed class Bc0VcoCoarseTuneTable
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public byte[] Value
        {
            get;
        }
    }
}