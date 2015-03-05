using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GitRemoteHead
    {
        public bool Local;
        public GitOid Oid;
        public GitOid Loid;
        public IntPtr NamePtr;
        public IntPtr SymRefTargetPtr;
    }
}
