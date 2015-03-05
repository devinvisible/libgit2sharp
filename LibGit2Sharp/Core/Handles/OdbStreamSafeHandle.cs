namespace LibGit2Sharp.Core.Handles
{
    public class OdbStreamSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_odb_stream_free(handle);
            return true;
        }
    }
}
