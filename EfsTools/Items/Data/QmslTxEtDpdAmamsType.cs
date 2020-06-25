using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxEtDpdAmamsType
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public uint[] Amam
        {
            get;
        }
    }
}