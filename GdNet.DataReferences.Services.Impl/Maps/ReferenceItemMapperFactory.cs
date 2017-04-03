using GdNet.DataReferences.Domain.List;
using GdNet.DataReferences.Services.Dtos;
using GdNet.Layers.AutoMapper;

namespace GdNet.DataReferences.Services.Impl.Maps
{
    public class ReferenceItemMapperFactory : DefaultEditableEntityMapperFactory<ReferenceItemDto, ReferenceItem>
    {
        protected override void OnMapperCreated()
        {
            base.OnMapperCreated();

            // Code will never be changed
            // Position will be updated by move up / move down action only
            // Value will not be changed implicitly, must be updated by specific scenarios

            MappingExpression.ForMember(x => x.Code, a => a.Ignore());
            MappingExpression.ForMember(x => x.Position, a => a.Ignore());
            MappingExpression.ForMember(x => x.Value, a => a.Ignore());
        }
    }
}