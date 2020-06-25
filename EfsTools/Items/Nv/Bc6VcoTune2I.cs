using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3242)]
    [Attributes(9)]
    public sealed class Bc6VcoTune2
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public byte[] Value
        {
            get;
        }
    }
}