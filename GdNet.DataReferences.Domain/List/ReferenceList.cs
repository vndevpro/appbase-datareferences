using GdNet.Domain.Entity;
using Rabbit.Foundation.List;
using System.Collections.Generic;
using System.Linq;

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

        public ReferenceItem GetItemByCode(string code)
        {
            return Items.FirstOrDefault(x => x.Code == code);
        }
    }
}
