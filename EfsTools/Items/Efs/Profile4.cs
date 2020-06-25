using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [EfsFile("/Data_Profiles/Profile4", false, 0x81B6)]
    [Attributes(9)]
    public sealed class Profile4 : ProfileBase
    {
    }
}