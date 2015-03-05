using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    public enum GitCloneLocal
    {
        CloneLocalAuto,
        CloneLocal,
        CloneNoLocal,
        CloneLocalNoLinks
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GitCloneOptions
    {
        public uint Version;

        public GitCheckoutOpts CheckoutOpts;
        public GitRemoteCallbacks RemoteCallbacks;

        public int Bare;
        public GitCloneLocal Local;
        public IntPtr CheckoutBranch;

        public IntPtr signature; // Really a SignatureSafeHandle

        public IntPtr RepositoryCb;
        public IntPtr RepositoryCbPayload;

        public IntPtr RemoteCb;
        public IntPtr RemoteCbPayload;
    }
}
