using GdNet.Domain.Entity;
using Rabbit.Foundation.List;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GdNet.DataReferences.Domain.List
{
    public class ReferenceList : ReferenceItemBase, IAggregateRoot
    {
        private readonly IList<ReferenceItem> _items;

        public ReferenceList()
        {
            _items = new List<ReferenceItem>();
        }

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
            throw new ArgumentException(string.Format("No item with code = {0} in this list", itemCode));
        }

        public virtual ReferenceList AddItem(ReferenceItem item)
        {
            if (_items.Contains(item) == false)
            {
                _items.Add(item);
            }
            return this;
        }

        public virtual ReferenceList RemoveItem(ReferenceItem item)
        {
            if (_items.Contains(item))
            {
                _items.Remove(item);
            }
            return this;
        }

        public virtual ReferenceList MoveItemUp(Guid itemId)
        {
            var item = _items.First(e => e.Id == itemId);
            var itemIndex = _items.IndexOf(item);

            // Only move up when the item is NOT on top of the list
            if (itemIndex > 0)
            {
                _items.RemoveAt(itemIndex);
                _items.Insert(itemIndex - 1, item);
            }

            return this;
        }

        public virtual ReferenceList MoveItemDown(Guid itemId)
        {
            var item = _items.First(e => e.Id == itemId);
            var itemIndex = _items.IndexOf(item);

            // Only move down when the item is NOT at bottom of the list
            if (itemIndex < _items.Count - 1)
            {
                _items.RemoveAt(itemIndex);
                _items.Insert(itemIndex + 1, item);
            }

            return this;
        }
    }
}
