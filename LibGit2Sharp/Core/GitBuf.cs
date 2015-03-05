using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core.Handles
{
    [StructLayout(LayoutKind.Sequential)]
    public class GitBuf : IDisposable
    {
        public IntPtr ptr;
        public UIntPtr asize;
        public UIntPtr size;

        public void Dispose()
        {
            Proxy.git_buf_free(this);
        }
    }
}
