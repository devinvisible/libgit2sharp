namespace LibGit2Sharp.Core.Handles
{
    public class ConfigurationIteratorSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_config_iterator_free(handle);
            return true;
        }
    }
}
