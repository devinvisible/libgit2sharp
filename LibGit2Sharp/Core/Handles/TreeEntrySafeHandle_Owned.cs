namespace LibGit2Sharp.Core.Handles
{
    public class TreeEntrySafeHandle_Owned : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_tree_entry_free(handle);
            return true;
        }
    }
}
