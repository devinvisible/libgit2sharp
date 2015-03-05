namespace LibGit2Sharp.Core.Handles
{
    public class RemoteSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_remote_free(handle);
            return true;
        }
    }
}
