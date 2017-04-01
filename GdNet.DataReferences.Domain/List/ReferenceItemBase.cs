using GdNet.Domain.Entity;

namespace GdNet.DataReferences.Domain.List
{
    public abstract class ReferenceItemBase : EditableEntityBase
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int Position { get; set; }
    }
}