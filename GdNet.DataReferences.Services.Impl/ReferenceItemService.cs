using System.Collections.Generic;
using GdNet.DataReferences.Domain;
using GdNet.DataReferences.Domain.List;
using GdNet.DataReferences.Services.Dtos;
using GdNet.Layers.Services;
using Mapping.Common.Contracts;

namespace GdNet.DataReferences.Services.Impl
{
    public class ReferenceItemService : ServiceBase<ReferenceItemDto, ReferenceItem>, IReferenceItemService
    {
        private readonly IReferenceItemRepository _repository;

        public ReferenceItemService(IReferenceItemRepository repository, IMapperProvider mapperProvider)
            : base(repository, mapperProvider)
        {
            _repository = repository;
        }

        public ReferenceItemDto GetByCode(object value)
        {
            return MapperProvider.Map(_repository.GetByCode(value), new ReferenceItemDto());
        }

        public IEnumerable<ReferenceItemDto> GetByCodes(params string[] codes)
        {
            foreach (var item in _repository.GetByCodes(codes))
            {
                yield return MapperProvider.Map(item, new ReferenceItemDto());
            }
        }
    }
}