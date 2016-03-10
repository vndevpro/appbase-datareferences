using GdNet.Data.EF;
using GdNet.Data.EF.Strategies;
using GdNet.DataReferences.Domain;
using GdNet.DataReferences.Domain.List;
using System.Data.Entity;
using System.Linq;

namespace GdNet.DataReferences.EF
{
    public class EfReferenceItemRepository : EfRepositoryBase<ReferenceItem>, IReferenceItemRepository
    {
        public EfReferenceItemRepository(IDbSet<ReferenceItem> entities)
            : base(entities)
        {
        }

        public EfReferenceItemRepository(IDbSet<ReferenceItem> entities, ISavingStrategy savingStrategy, IDeletionStrategy<ReferenceItem> deletionStrategy)
            : base(entities, savingStrategy, deletionStrategy)
        {
        }

        public ReferenceItem GetByCode(object value)
        {
            return Entities.FirstOrDefault(x => x.Code == (string)value);
        }
    }
}