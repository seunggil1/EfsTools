using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3065)]
    [Attributes(9)]
    public sealed class DcsPaEnStart
    {
        public short Value { get; set; }
    }
}