using System;

namespace LibGit2Sharp.Core.Handles
{
    public class NullGitObjectSafeHandle : GitObjectSafeHandle
    {
        public NullGitObjectSafeHandle()
        {
            handle = IntPtr.Zero;
        }

        protected override bool ReleaseHandleImpl()
        {
            // Nothing to release
            return true;
        }
    }
}
