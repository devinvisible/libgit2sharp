using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core.Handles
{
    public class IndexReucEntrySafeHandle : NotOwnedSafeHandleBase
    {
        public GitIndexReucEntry MarshalAsGitIndexReucEntry()
        {
            return handle.MarshalAs<GitIndexReucEntry>();
        }
    }
}
