using GdNet.DataReferences.Domain.List;
using System.Data.Entity;

namespace GdNet.DataReferences.EF
{
    public class DataReferenceContext : DbContext, IDataReferenceContext
    {
        public DataReferenceContext()
            : base("DR")
        {
        }

        public DataReferenceContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public IDbSet<ReferenceList> Lists { get; set; }

        public IDbSet<ReferenceItem> Items { get; set; }
    }
}
