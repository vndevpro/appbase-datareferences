using GdNet.Common;
using GdNet.DataReferences.Domain;
using GdNet.DataReferences.Domain.List;
using GdNet.DataReferences.Services.Dtos;
using GdNet.Layers.Services;
using Mapping.Common.Contracts;

namespace GdNet.DataReferences.Services.Impl
{
    public class ReferenceListService : ServiceBase<ReferenceListDto, ReferenceList>, IReferenceListService
    {
        private readonly IReferenceListRepository _repository;

        public ReferenceListService(IReferenceListRepository repository, IMapperProvider mapperProvider)
            : base(repository, mapperProvider)
        {
            _repository = repository;
        }

        public ReferenceListDto GetByCode(object value)
        {
            return MapperProvider.Map(_repository.GetByCode(value), new ReferenceListDto());
        }
        
        public void MoveItem(MoveItemParamEventArgs args)
        {
            var referenceList = _repository.GetById(args.ReferenceListId);
            if (args.Direction == Direction.Up)
            {
                referenceList.MoveItemUp(args.ReferenceItemId);
            }
            else
            {
                referenceList.MoveItemDown(args.ReferenceItemId);
            }
        }
    }
}