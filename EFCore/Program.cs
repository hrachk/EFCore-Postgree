// See https://aka.ms/new-console-template for more information


using EFCore.Entities;

class Program
{
    static void Main()
    {
        List<Department> departments = new List<Department> {
            new Department() { DepartmentName="Dep1" },
            new Department() { DepartmentName="Dep2" },
            new Department() { DepartmentName="Dep3" } };

        var persons = new List<Person> {
        new Person() { Name="Joe", Surname="Smith", Department=departments[0] },
        new Person() { Name="Jully", Surname="Roberts", Department=departments[1] },
        new Person() { Name="Marry", Surname="Chirsman", Department=departments[2] },

        };
        using (var context = new Context())
        {
            foreach (var person in persons)
            {
                context.Add(person);
            }
            
            context.SaveChanges();

        }
    }

}
