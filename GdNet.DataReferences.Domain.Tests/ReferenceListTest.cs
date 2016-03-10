using GdNet.DataReferences.Domain.List;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GdNet.DataReferences.Domain.Tests
{
    [TestClass]
    public class ReferenceListTest
    {
        private ReferenceList CreateSUT()
        {
            return new ReferenceList();
        }

        [TestMethod]
        public void EnsureNewReferenceListWithDefaultDataCorrectly()
        {
            // Act
            var refList = CreateSUT();

            // Assert
            Assert.IsTrue(string.IsNullOrWhiteSpace(refList.Code));
            Assert.IsTrue(string.IsNullOrWhiteSpace(refList.Name));
            Assert.AreEqual(false, refList.Manageable);
            Assert.AreEqual(0, refList.Items.Count);
        }
    }
}
