using System;
using System.Linq;
using Rabbit.Foundation.List;

namespace GdNet.DataReferences.Domain.List
{
    public class ReferenceItemCollectionValidator : DefaultSmartListValidator<ReferenceItem>, IReferenceItemCollectionValidator
    {
        public override void OnBeforeAdd(ISmartList<ReferenceItem> list, ReferenceItem item)
        {
            if (list.Any(x => x.Id == item.Id))
            {
                throw new ArgumentException(string.Format("Item with Id = {0} already exists in the list", item.Id));
            }

            if (list.Any(x => string.Equals(x.Code, item.Code, StringComparison.InvariantCultureIgnoreCase)))
            {
                throw new ArgumentException(string.Format("Item with code = {0} already exists in the list", item.Code));
            }
        }
    }
}
