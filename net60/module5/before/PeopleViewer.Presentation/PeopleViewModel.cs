using PeopleViewer.Common;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PeopleViewer.Presentation;

public class PeopleViewModel : INotifyPropertyChanged
{
    protected IPersonReader DataReader;

    private IEnumerable<Person> _people = new List<Person>();

    public IEnumerable<Person> People
    {
        get => _people;
        set { _people = value; RaisePropertyChanged(); }
    }

    public PeopleViewModel(IPersonReader dataReader)
    {
        DataReader = dataReader;
    }

    public void RefreshPeople()
    {
        People = DataReader.GetPeople();
    }

    public void ClearPeople()
    {
        People = new List<Person>();
    }

    public string DataReaderType
    {
        get { return DataReader.GetType().ToString(); }
    }


    #region INotifyPropertyChanged Members

    public event PropertyChangedEventHandler? PropertyChanged;
    private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}