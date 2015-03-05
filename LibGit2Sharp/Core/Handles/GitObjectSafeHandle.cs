namespace LibGit2Sharp.Core.Handles
{
    public class GitObjectSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_object_free(handle);
            return true;
        }
    }
}
