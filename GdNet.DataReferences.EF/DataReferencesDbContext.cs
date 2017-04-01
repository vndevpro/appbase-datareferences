using GdNet.DataReferences.Domain.List;
using System.Configuration;
using System.Data.Entity;

namespace GdNet.DataReferences.EF
{
    public class DataReferencesDbContext : DbContext, IDataReferenceContext
    {
        /// <summary>
        /// The default constructor uses connection string named DR
        /// </summary>
        public DataReferencesDbContext()
            : this("DR")
        {
        }

        public DataReferencesDbContext(string connectionStringName)
            : base(ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString)
        {
        }

        public IDbSet<ReferenceList> Lists { get; set; }

        public IDbSet<ReferenceItem> Items { get; set; }
    }
}
