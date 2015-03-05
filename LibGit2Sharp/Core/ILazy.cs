namespace LibGit2Sharp.Core
{
    public interface ILazy<T>
    {
        T Value { get; }
    }
}
