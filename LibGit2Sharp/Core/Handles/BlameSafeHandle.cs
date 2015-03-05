namespace LibGit2Sharp.Core.Handles
{
    public class BlameSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_blame_free(handle);
            return true;
        }
    }
}
