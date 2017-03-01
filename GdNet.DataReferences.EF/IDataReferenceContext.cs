using GdNet.DataReferences.Domain.List;
using System.Data.Entity;

namespace GdNet.DataReferences.EF
{
    public interface IDataReferenceContext
    {
        IDbSet<ReferenceList> Lists { get; set; }

        IDbSet<ReferenceItem> Items { get; set; }

        int SaveChanges();
    }
}