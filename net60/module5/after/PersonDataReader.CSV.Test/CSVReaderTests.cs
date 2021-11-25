using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonDataReader.CSV.Test
{
    [TestClass]
    public class CSVReaderTests
    {
        [TestMethod]
        public void GetPeople_WithGoodRecords_ReturnsAllRecords()
        {
            var reader = new CSVReader();
            reader.FileLoader = new FakeFileLoader("Good");

            var result = reader.GetPeople();

            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void GetPeople_WithNoFile_ThrowsFileNotFoundException()
        {
            var reader = new CSVReader();

            Assert.ThrowsException<FileNotFoundException>(
                () => reader.GetPeople());
        }

        [TestMethod]
        public void GetPeople_WithOnlyBadRecords_ReturnsEmptyList()
        {
            var reader = new CSVReader();
            reader.FileLoader = new FakeFileLoader("Bad");

            var result = reader.GetPeople();

            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void GetPeople_withEmptyFile_ReturnsEmptyList()
        {
            var reader = new CSVReader();
            reader.FileLoader = new FakeFileLoader("Empty");

            var result = reader.GetPeople();

            Assert.AreEqual(0, result.Count());
        }
    }
}