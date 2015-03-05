namespace LibGit2Sharp.Core
{
    public static class FilePathExtensions
    {
        public static FilePath Combine(this FilePath @this, string childPath)
        {
            return @this.IsNullOrEmpty() ? childPath : @this.Posix + "/" + childPath;
        }

        public static bool IsNullOrEmpty(this FilePath @this)
        {
            return ReferenceEquals(@this, null) || @this.Posix.Length == 0;
        }
    }
}