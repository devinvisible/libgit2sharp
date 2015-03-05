namespace LibGit2Sharp.Core.Handles
{
    public class ReferenceSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_reference_free(handle);
            return true;
        }
    }
}
