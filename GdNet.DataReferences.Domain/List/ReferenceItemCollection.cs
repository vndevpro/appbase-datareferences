using System.Collections.Generic;
using Rabbit.Foundation.List;

namespace GdNet.DataReferences.Domain.List
{
    public class ReferenceItemCollection : SmartList<ReferenceItem>
    {
        public ReferenceItemCollection()
            : base(new ReferenceItemCollectionValidator())
        {
        }

        public ReferenceItemCollection(IList<ReferenceItem> items)
            : base(items, new ReferenceItemCollectionValidator())
        {
        }
    }
}