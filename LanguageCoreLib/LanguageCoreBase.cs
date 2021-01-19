namespace LanguageCoreLib
{
    public abstract class Token
    {
    }

    public abstract class AbstractIdentifier : Token
    {
    }

    public class UIntIdentifier : AbstractIdentifier
    {
        public UIntIdentifier(uint value) => Value = value;

        public uint Value { get; }
    }

    public abstract class AbstractNode<TIdentifier> : Token
        where TIdentifier : AbstractIdentifier
    {
        protected AbstractNode(TIdentifier id) => Id = id;

        public TIdentifier Id { get; }
    }
}