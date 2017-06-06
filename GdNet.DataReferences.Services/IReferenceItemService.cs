using System.Collections.Generic;
using GdNet.DataReferences.Services.Dtos;
using GdNet.Layers.Services;

namespace GdNet.DataReferences.Services
{
    /// <summary>
    /// Service on ReferenceItem
    /// </summary>
    public interface IReferenceItemService : IServiceBase<ReferenceItemDto>
    {
        /// <summary>
        /// Get a ReferenceItem by its code
        /// </summary>
        ReferenceItemDto GetByCode(object value);

        IEnumerable<ReferenceItemDto> GetByCodes(params string[] codes);
    }
}