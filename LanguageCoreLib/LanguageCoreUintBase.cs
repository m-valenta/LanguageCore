namespace LanguageCoreLib
{
    public abstract class AbstractNodeWithUintIdentifier : AbstractNode<UIntIdentifier>
    {
        protected AbstractNodeWithUintIdentifier(UIntIdentifier id) : base(id)
        {
        }
    }

    public abstract class AbstractValue : AbstractNodeWithUintIdentifier
    {
        protected AbstractValue(UIntIdentifier id) : base(id)
        {
        }
    }

    public abstract class AbstractValueType : AbstractNodeWithUintIdentifier
    {
        protected AbstractValueType(UIntIdentifier id) : base(id)
        {
        }
    }

    public abstract class AbstractReferenceType : AbstractNodeWithUintIdentifier
    {
        protected AbstractReferenceType(UIntIdentifier id) : base(id)
        {
        }
    }

    public class Node : AbstractNodeWithUintIdentifier
    {
        public Node(UIntIdentifier id, AbstractValue value)
            : base(id)
            => Value = value;

        public StringType Name => StringType.Instance;
        public AbstractValue Value { get; }
    }
}