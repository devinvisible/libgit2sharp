namespace LibGit2Sharp.Core.Handles
{
    public class SubmoduleSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_submodule_free(handle);
            return true;
        }
    }
}
