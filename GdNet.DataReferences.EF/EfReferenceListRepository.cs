using System.Collections.Generic;
using GdNet.Data.EF;
using GdNet.Data.EF.Strategies;
using GdNet.DataReferences.Domain;
using GdNet.DataReferences.Domain.List;
using System.Data.Entity;
using System.Linq;

namespace GdNet.DataReferences.EF
{
    public class EfReferenceListRepository : EfRepositoryBase<ReferenceList>, IReferenceListRepository
    {
        public EfReferenceListRepository(IDbSet<ReferenceList> entities)
            : base(entities)
        {
        }

        public EfReferenceListRepository(IDbSet<ReferenceList> entities, ISavingStrategy savingStrategy, IDeletionStrategy<ReferenceList> deletionStrategy)
            : base(entities, savingStrategy, deletionStrategy)
        {
        }

        /// <summary>
        /// Get the list and all its items
        /// </summary>
        public ReferenceList GetByCode(object value)
        {
            return Entities.Include(x => x.Items).FirstOrDefault(x => x.Code == (string)value);
        }

        public IEnumerable<ReferenceList> GetByCodes(params string[] codes)
        {
            return Entities.Include(x => x.Items).Where(x => codes.Contains(x.Code));
        }
    }
}