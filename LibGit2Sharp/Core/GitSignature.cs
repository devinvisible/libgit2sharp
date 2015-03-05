using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public class GitSignature
    {
        public IntPtr Name;
        public IntPtr Email;
        public GitTime When;
    }
}
