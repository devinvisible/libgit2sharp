namespace LibGit2Sharp.Core.Handles
{
    public class NoteSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandleImpl()
        {
            Proxy.git_note_free(handle);
            return true;
        }
    }
}
