using System.Collections.Generic;
using GdNet.DataReferences.Domain.List;
using GdNet.Domain.Repository;

namespace GdNet.DataReferences.Domain
{
    public interface IReferenceListRepository : IRepositoryBase<ReferenceList>
    {
        ReferenceList GetByCode(object value);

        IEnumerable<ReferenceList> GetByCodes(params string[] codes);
    }
}
