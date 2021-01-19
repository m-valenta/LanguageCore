namespace LanguageCoreLib.Models
{
    internal static class Tokens
    {
        public static readonly CollectionOf<ModelReference> UsingCollection =
            CollectionOf<ModelReference>.Instance(LanguageCoreLib.TokenIds.ModelUsingCollection);
        
        public static readonly CollectionOf<AbstractModelNode> ChildrenCollection =
            CollectionOf<AbstractModelNode>.Instance(LanguageCoreLib.TokenIds.ModelChildrenCollection);
    }
}