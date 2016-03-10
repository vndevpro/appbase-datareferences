using GdNet.Layers.Dtos;
using System.Collections.Generic;

namespace GdNet.DataReferences.Services.Dtos
{
    public class ReferenceListDto : EditableEntityDto
    {
        public ReferenceListDto()
        {
            Items = new List<ReferenceItemDto>();
        }

        public string Code { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// True if item(s) of the list can be manageable from GUI
        /// </summary>
        public bool Manageable { get; set; }

        public IList<ReferenceItemDto> Items { get; private set; }
    }
}
