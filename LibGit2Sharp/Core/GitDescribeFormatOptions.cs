using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GitDescribeFormatOptions
    {
        public uint Version;
        public uint MinAbbreviatedSize;
        public bool AlwaysUseLongFormat;
        public IntPtr DirtySuffix;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GitDescribeOptions
    {
        public uint Version;
        public uint MaxCandidatesTags;
        public DescribeStrategy DescribeStrategy;
        public IntPtr Pattern;
        public bool OnlyFollowFirstParent;
        public bool ShowCommitOidAsFallback;
    }
}
