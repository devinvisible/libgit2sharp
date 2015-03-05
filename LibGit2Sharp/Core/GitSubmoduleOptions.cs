using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GitSubmoduleOptions
    {
        public uint Version;

        public GitCheckoutOpts CheckoutOptions;

        public GitRemoteCallbacks RemoteCallbacks;

        public CheckoutStrategy CloneCheckoutStrategy;
    }
}
