namespace LibGit2Sharp.Core.Handles
{
    public class ConfigurationSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_config_free(handle);
            return true;
        }
    }
}
