using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/ims/qipcall_confrd_uri", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QipcallConfrdUri
    {
        public ushort Value { get; set; }
    }
}