using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public class GitIndexTime
    {
        public long seconds;
        public uint nanoseconds;
    }
}
