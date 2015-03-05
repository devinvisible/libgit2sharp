using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public class GitIndexNameEntry
    {
        public IntPtr Ancestor;
        public IntPtr Ours;
        public IntPtr Theirs;
    }
}
