using GdNet.Domain.Entity;

namespace GdNet.DataReferences.Domain.List
{
    public class ReferenceItem : ReferenceItemBase, IAggregateRoot
    {
        public string Value { get; set; }
    }
}
