using GdNet.DataReferences.Domain.List;
using GdNet.DataReferences.Services.Dtos;
using Mapping.AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace GdNet.DataReferences.Services.Impl.Maps
{
    public class ReferenceListDtoMapperFactory : AutoMapperFactory<ReferenceList, ReferenceListDto>
    {
        protected override void OnMapperCreated()
        {
            base.OnMapperCreated();

            MappingExpression.ForMember(x => x.Items, a => a.MapFrom(list => MapItems(list)));
        }

        private IList<ReferenceItemDto> MapItems(ReferenceList list)
        {
            return list == null
                ? Enumerable.Empty<ReferenceItemDto>().ToList()
                : list.Items.Select(x => MapperProvider.Map(x, new ReferenceItemDto())).ToList();
        }
    }
}
