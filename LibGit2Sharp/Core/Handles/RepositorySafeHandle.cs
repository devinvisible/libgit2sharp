namespace LibGit2Sharp.Core.Handles
{
    public class RepositorySafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_repository_free(handle);
            return true;
        }
    }
}
