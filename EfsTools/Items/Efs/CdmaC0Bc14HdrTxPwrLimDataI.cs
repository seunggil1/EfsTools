using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/rfnv/00023733", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc14HdrTxPwrLimData
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
        public QmslTxPwrLimitDataType[] HdrTxPwrLimit
        {
            get;
        }
    }
}