namespace LanguageCoreLib
{
    internal static class TokenIds
    {
        // Basic types
        public static readonly UIntIdentifier StringType = new UIntIdentifier(1001);
        public static readonly UIntIdentifier UintType = new UIntIdentifier(1002);
        
        public static readonly UIntIdentifier EnumerationDefinition = new UIntIdentifier(1101);
        public static readonly UIntIdentifier EnumerationDefinitionItemCollection = new UIntIdentifier(1102);
        public static readonly UIntIdentifier EnumerationItem = new UIntIdentifier(1103);
        
        // Model
        public static readonly UIntIdentifier Model = new UIntIdentifier(2001);
        public static readonly UIntIdentifier ModelReference = new UIntIdentifier(2002);
        public static readonly UIntIdentifier ModelNodeReference = new UIntIdentifier(2003);
        public static readonly UIntIdentifier ModelUsingCollection = new UIntIdentifier(2004);
        public static readonly UIntIdentifier ModelChildrenCollection = new UIntIdentifier(2005);



    }
}