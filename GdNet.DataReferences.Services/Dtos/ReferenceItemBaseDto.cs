using GdNet.Layers.Dtos;

namespace GdNet.DataReferences.Services.Dtos
{
    public abstract class ReferenceItemBaseDto : EditableEntityDto
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int Position { set; get; }
    }
}