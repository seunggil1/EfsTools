using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5895)]
    [Attributes(9)]
    public sealed class MgrfSupported
    {
        public byte Value { get; set; }
    }
}