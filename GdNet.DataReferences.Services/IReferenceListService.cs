using GdNet.DataReferences.Services.Args;
using GdNet.DataReferences.Services.Dtos;
using GdNet.Layers.Services;
using System;

namespace GdNet.DataReferences.Services
{
    /// <summary>
    /// Service on ReferenceList
    /// </summary>
    public interface IReferenceListService : IServiceBase<ReferenceListDto>
    {
        /// <summary>
        /// Get a ReferenceList by its code
        /// </summary>
        ReferenceListDto GetByCode(object value);

        /// <summary>
        /// Change position of item in the list
        /// </summary>
        /// <param name="args"></param>
        void MoveItem(MoveItemParamEventArgs args);

        void AddItems(Guid referenceListId, params ReferenceItemDto[] items);

        void UpdateItem(Guid referenceListId, ReferenceItemDto item);
    }
}