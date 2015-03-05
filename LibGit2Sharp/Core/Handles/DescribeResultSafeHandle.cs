namespace LibGit2Sharp.Core.Handles
{
    public class DescribeResultSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_describe_free(handle);
            return true;
        }
    }
}
