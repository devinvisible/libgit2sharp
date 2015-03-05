namespace LibGit2Sharp
{
    public class VoidReference : Reference
    {
        public VoidReference(IRepository repo, string canonicalName)
            : base(repo, canonicalName, null)
        { }

        public override DirectReference ResolveToDirectReference()
        {
            return null;
        }
    }
}
