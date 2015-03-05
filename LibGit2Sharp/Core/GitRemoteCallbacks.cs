using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    /// <summary>
    /// Structure for git_remote_callbacks
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GitRemoteCallbacks
    {
        public uint version;

        public NativeMethods.remote_progress_callback progress;

        public NativeMethods.remote_completion_callback completion;

        public NativeMethods.git_cred_acquire_cb acquire_credentials;

        public IntPtr certificate_check;

        public NativeMethods.git_transfer_progress_callback download_progress;

        public NativeMethods.remote_update_tips_callback update_tips;

        public NativeMethods.git_packbuilder_progress pack_progress;

        public NativeMethods.git_push_transfer_progress push_transfer_progress;

        public IntPtr push_update_reference;

        public IntPtr payload;
    }
}
