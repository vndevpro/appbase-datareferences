using GdNet.DataReferences.Domain.List;
using GdNet.DataReferences.Services.Dtos;
using GdNet.Layers.AutoMapper;

namespace GdNet.DataReferences.Services.Impl.Maps
{
    public class ReferenceListMapperFactory : DefaultEditableEntityMapperFactory<ReferenceListDto, ReferenceList>
    {
        protected override void OnMapperCreated()
        {
            base.OnMapperCreated();

            MappingExpression.ForMember(x => x.Code, a => a.Ignore());
            MappingExpression.ForMember(x => x.Position, a => a.Ignore());
            MappingExpression.ForMember(x => x.Items, a => a.Ignore());
        }
    }
}