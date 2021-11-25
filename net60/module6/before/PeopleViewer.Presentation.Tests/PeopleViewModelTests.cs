using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeopleViewer.Presentation.Tests;

[TestClass]
public class PeopleViewModelTests
{
    [TestMethod]
    public void People_OnRefreshPeople_IsPopulated()
    {
        // Arrange
        var reader = new FakeReader();
        var viewModel = new PeopleViewModel(reader);

        // Act
        viewModel.RefreshPeople();

        // Assert
        Assert.IsNotNull(viewModel.People);
        Assert.AreEqual(2, viewModel.People.Count());
    }

    [TestMethod]
    public void People_OnClearPeople_IsEmpty()
    {
        // Arrange
        var reader = new FakeReader();
        var viewModel = new PeopleViewModel(reader);
        viewModel.RefreshPeople();
        Assert.AreNotEqual(0, viewModel.People.Count(),
            "Invalid arrangement");

        // Act
        viewModel.ClearPeople();

        // Assert
        Assert.AreEqual(0, viewModel.People.Count());
    }
}
