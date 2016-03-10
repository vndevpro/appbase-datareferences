﻿using GdNet.Domain.Entity;

namespace GdNet.DataReferences.Domain.List
{
    public class ReferenceItem : EditableEntityBase, IAggregateRoot
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
