using System.Collections.Generic;

namespace GdNet.DataReferences.Services.Dtos
{
    public class ReferenceListDto : ReferenceItemBaseDto
    {
        public ReferenceListDto()
        {
            Items = new List<ReferenceItemDto>();
        }

        /// <summary>
        /// True if item(s) of the list can be manageable from GUI
        /// </summary>
        public bool Manageable { get; set; }

        public IList<ReferenceItemDto> Items { get; private set; }
    }
}
