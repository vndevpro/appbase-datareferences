using GdNet.Common;
using GdNet.DataReferences.Domain;
using GdNet.DataReferences.Domain.List;
using GdNet.DataReferences.Services.Args;
using GdNet.DataReferences.Services.Dtos;
using GdNet.Layers.Services;
using Mapping.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<ReferenceListDto> GetByCodes(params string[] codes)
        {
            foreach (var referenceList in _repository.GetByCodes(codes))
            {
                yield return MapperProvider.Map(referenceList, new ReferenceListDto());
            }
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

        public void AddItems(Guid referenceListId, params ReferenceItemDto[] items)
        {
            var referenceList = _repository.GetById(referenceListId);
            AddItems(referenceList, items);

            _repository.Save(referenceList);
        }

        private void AddItems(ReferenceList referenceList, params ReferenceItemDto[] items)
        {
            foreach (var referenceItem in items.Select(referenceItemDto =>
            {
                var item = MapperProvider.Map(referenceItemDto, new ReferenceItem());
                item.Code = referenceItemDto.Code;
                return item;
            }))
            {
                referenceList.AddItem(referenceItem);
            }
        }

        public void UpdateItem(Guid referenceListId, ReferenceItemDto item)
        {
            var referenceList = _repository.GetById(referenceListId);
            var referenceItem = referenceList.GetItemBy(item.Code);
            MapperProvider.Map(item, referenceItem);
        }
    }
}
