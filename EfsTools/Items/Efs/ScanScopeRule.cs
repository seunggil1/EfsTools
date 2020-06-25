using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/scan_scope_rule", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class ScanScopeRule
    {
        public byte Value { get; set; }
    }
}