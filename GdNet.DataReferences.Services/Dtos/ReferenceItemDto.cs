using GdNet.Layers.Dtos;

namespace GdNet.DataReferences.Services.Dtos
{
    public class ReferenceItemDto : EditableEntityDto
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}