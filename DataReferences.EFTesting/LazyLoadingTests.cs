using System.Linq;
using GdNet.DataReferences.EF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Entity;

namespace DataReferences.EFTesting
{
    [TestClass]
    public class LazyLoadingTests
    {
        [TestMethod]
        public void CanLoadItemsOfAListLazily()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DataReferencesDbContext>());


            // Arrange
            var context = new DataReferencesDbContext();
            var listId = Guid.Parse("4F3C14D5-F20B-4CF3-A9F8-5974AC71C499");
            var list1 = context.Lists.First(x => x.Id == listId);

            // Act
            int itemCount = list1.Items.Count;

            // Assert
            Assert.AreEqual(2, itemCount);
        }
    }
}
