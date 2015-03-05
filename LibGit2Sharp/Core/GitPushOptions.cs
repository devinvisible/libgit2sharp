using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public class GitPushOptions
    {
        public int Version = 1;
        public int PackbuilderDegreeOfParallelism;
    }
}
