using System.Collections.Generic;

namespace PersonDataReader.CSV.Tests
{
    public class FakeFileLoader : ICSVFileLoader
    {
        private string _dataType;

        public FakeFileLoader(string dataType)
        {
            _dataType = dataType;
        }

        public IReadOnlyCollection<string> LoadFile()
        {
            switch (_dataType)
            {
                case "Good": return TestData.WithGoodRecords;
                case "Mixed": return TestData.WithGoodAndBadRecords;
                case "Bad": return TestData.WithOnlyBadRecords;
                case "Empty": return new List<string>();
                default: return TestData.WithGoodRecords;
            }
        }
    }
}
