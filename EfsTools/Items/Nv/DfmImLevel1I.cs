using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(613)]
    [Attributes(9)]
    public sealed class DfmImLevel1
    {
        public sbyte Value { get; set; }
    }
}