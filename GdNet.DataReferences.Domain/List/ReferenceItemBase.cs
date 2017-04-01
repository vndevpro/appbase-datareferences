using GdNet.Domain.Entity;

namespace GdNet.DataReferences.Domain.List
{
    public abstract class ReferenceItemBase<T> : EditableEntityBase
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public abstract T ValueObject { get; set; }
    }
}