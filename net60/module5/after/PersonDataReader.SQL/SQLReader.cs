using Microsoft.EntityFrameworkCore;
using PeopleViewer.Common;

namespace PersonDataReader.SQL;

public class SQLReader : IPersonReader
{
    DbContextOptions<PersonContext> options;

    public SQLReader()
    {
        var optionsBuilder = new DbContextOptionsBuilder<PersonContext>();
        optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}People.db");
        options = optionsBuilder.Options;
    }

    public IEnumerable<Person> GetPeople()
    {
        using (var context = new PersonContext(options))
        {
            return context.People!.ToList();
        }
    }

    public Person GetPerson(int id)
    {
        using (var context = new PersonContext(options))
        {
            return context.People!.Where(p => p.Id == id).First();
        }
    }
}

