using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public class GitSmartSubtransportRegistration
    {
        public IntPtr SubtransportCallback;
        public uint Rpc;

        public delegate int create_callback(
            out IntPtr subtransport,
            IntPtr transport);
    }
}
