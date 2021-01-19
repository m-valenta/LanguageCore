namespace LanguageCoreLib
{
    public class StringType : AbstractValueType
    {
        private StringType() : base(TokenIds.StringType)
        {
        }

        public static readonly StringType Instance = new StringType();
    }

    public abstract class AbstractNumericType : AbstractValueType
    {
        protected AbstractNumericType(UIntIdentifier id) : base(id)
        {
        }
    }

    public class UintType : AbstractValueType
    {
        private UintType() : base(TokenIds.UintType)
        {
        }

        public static readonly UintType Instance = new UintType();
    }

    public class CollectionOf<TValue> : AbstractReferenceType
        where TValue : AbstractNodeWithUintIdentifier
    {
        CollectionOf(UIntIdentifier id) : base(id)
        {
        }

        public static CollectionOf<TValue> Instance(UIntIdentifier id) => new CollectionOf<TValue>(id);
    }

    public class EnumerationDefinition<TValue>: AbstractValueType 
        where TValue: AbstractNumericType
    {
        public EnumerationDefinition(): base(TokenIds.EnumerationDefinition)
        {
        }
        
        public CollectionOf<EnumerationItem<TValue>> Items = CollectionOf<EnumerationItem<TValue>>.Instance(TokenIds.EnumerationDefinitionItemCollection);
    }

    public class EnumerationItem<TValue>: AbstractValueType where TValue: AbstractNumericType
    {
        private EnumerationItem(AbstractNumericType value): base(TokenIds.EnumerationItem)
        {
            Value = value;
        }
        
        public StringType Name => StringType.Instance;
        public AbstractNumericType Value { get;  }

        public static EnumerationItem<TValue> Instance(AbstractNumericType value) =>
            new EnumerationItem<TValue>(value);
    }


}