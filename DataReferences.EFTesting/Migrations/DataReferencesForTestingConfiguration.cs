using System;
using System.Data.Entity.Migrations;
using GdNet.DataReferences.Domain.List;
using GdNet.DataReferences.EF;
using GdNet.DataReferences.EF.Migrations;

namespace DataReferences.EFTesting.Migrations
{
    public class DataReferencesForTestingConfiguration : Configuration
    {
        protected override void Seed(DataReferencesDbContext context)
        {
            base.Seed(context);

            var referenceList1 = new ReferenceList()
                {
                    Id = Guid.Parse("4F3C14D5-F20B-4CF3-A9F8-5974AC71C499"),
                    Name = "Gender List",
                    Code = "gender-list"
                };
            referenceList1.Items.Add(new ReferenceItem()
                {
                    Id = Guid.Parse("4F3C14D5-F20B-4CF3-A9F8-5974AC71C498"),
                    Name = "Male",
                    Code = "gender-male"
                });
            referenceList1.Items.Add(new ReferenceItem()
            {
                Id = Guid.Parse("4F3C14D5-F20B-4CF3-A9F8-5974AC71C497"),
                Name = "Female",
                Code = "gender-female"
            });
            context.Lists.AddOrUpdate(referenceList1);

            context.SaveChanges();
        }
    }
}
