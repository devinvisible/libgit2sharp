namespace LibGit2Sharp.Core.Handles
{
    public class ObjectDatabaseSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_odb_free(handle);
            return true;
        }
    }
}
