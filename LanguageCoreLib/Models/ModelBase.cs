namespace LanguageCoreLib.Models
{
    public class ModelReference : AbstractValue
    {
        private ModelReference(UIntIdentifier id) : base(id)
        {
        }

        public UintType OwnerId => UintType.Instance;
        public UintType Id => UintType.Instance;
        public UintType Version => UintType.Instance;
        public StringType LocalIdentifier => StringType.Instance;

        public static readonly ModelReference Instance = new ModelReference(TokenIds.ModelReference);
    }

    public class ModelNodeReference : AbstractValue
    {
        protected ModelNodeReference(UIntIdentifier id) : base(id)
        {
        }

        public StringType ModelIdentifier => StringType.Instance;
        public UintType Id => UintType.Instance;

        public static ModelNodeReference Instance => new ModelNodeReference(TokenIds.ModelNodeReference);
    }

    public abstract class AbstractModelNode : AbstractNodeWithUintIdentifier
    {
        public AbstractModelNode(UIntIdentifier id) : base(id)
        {
        }
        
        public ModelNodeReference Id => ModelNodeReference.Instance;
        
        public ModelNodeReference BaseNodeReference => ModelNodeReference.Instance;
    }


    public class Model : AbstractNodeWithUintIdentifier
    {
        private Model() : base(TokenIds.Model)
        {
        }

        public UintType LanguageCoreVersion => UintType.Instance;

        public CollectionOf<ModelReference> Usings => Tokens.UsingCollection;

        public ModelReference Id => ModelReference.Instance;

        public StringType Name => StringType.Instance;

        public CollectionOf<AbstractModelNode> Children => Tokens.ChildrenCollection;

        public static readonly Model Instance = new Model();
    }
}