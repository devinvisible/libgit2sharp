namespace LibGit2Sharp.Core.Handles
{
    public class TreeBuilderSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_treebuilder_free(handle);
            return true;
        }
    }
}
