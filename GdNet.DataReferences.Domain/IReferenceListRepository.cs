using GdNet.DataReferences.Domain.List;
using GdNet.Domain.Repository;

namespace GdNet.DataReferences.Domain
{
    public interface IReferenceListRepository : IRepositoryBase<ReferenceList>
    {
        ReferenceList GetByCode(object value);
    }
}
