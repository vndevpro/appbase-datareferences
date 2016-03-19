using System;
using System.Collections.Generic;
using System.Linq;
using GdNet.Domain.Entity;
using Rabbit.Foundation.List;

namespace GdNet.DataReferences.Domain.List
{
    public class ReferenceList : EditableEntityBase, IAggregateRoot
    {
        private readonly List<ReferenceItem> _items;

        public ReferenceList()
        {
            _items = new List<ReferenceItem>();
        }

        public string Code { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// True if item(s) of the list can be manageable from GUI
        /// </summary>
        public bool Manageable { get; set; }

        public virtual ISmartList<ReferenceItem> Items
        {
            get { return new ReferenceItemCollection(_items); }
        }

        public ReferenceItem GetItemBy(string itemCode)
        {
            Func<ReferenceItem, bool> predicate = x => string.Equals(x.Code, itemCode, StringComparison.InvariantCultureIgnoreCase);

            if (Items.Any(predicate))
            {
                return Items.First(predicate);
            }

            // TODO: use a domain exception
            throw new ArgumentException(string.Format("No item with code {0} in this list", itemCode));
        }
    }
}
