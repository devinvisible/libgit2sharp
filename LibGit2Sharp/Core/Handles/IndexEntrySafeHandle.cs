using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core.Handles
{
    public class IndexEntrySafeHandle : NotOwnedSafeHandleBase
    {
        public GitIndexEntry MarshalAsGitIndexEntry()
        {
            return handle.MarshalAs<GitIndexEntry>();
        }
    }
}
