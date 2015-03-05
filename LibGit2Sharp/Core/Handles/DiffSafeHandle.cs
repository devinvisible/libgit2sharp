namespace LibGit2Sharp.Core.Handles
{
    public class DiffSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_diff_free(handle);
            return true;
        }
    }
}
