using GdNet.DataReferences.Domain.List;
using GdNet.Domain.Repository;

namespace GdNet.DataReferences.Domain
{
    public interface IReferenceItemRepository : IRepositoryBase<ReferenceItem>
    {
        ReferenceItem GetByCode(object value);
    }
}
