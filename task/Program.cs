namespace task
{
    /// <summary>
    /// Фильтрация. Проецирование. Объединение.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>()
            {
                new Department(){ Id = 1, Country = "Ukraine", City = "Lviv" },
                new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },
                new Department(){ Id = 3, Country = "France", City = "Paris" },
                new Department(){ Id = 4, Country = "Ukraine", City = "Odesa" }
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                    { Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },
                new Employee()
                    { Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
                new Employee()
                    { Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
                new Employee()
                    { Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
                new Employee()
                    { Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
                new Employee()
                    { Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
                new Employee()
                    { Id = 7, FirstName = "Nikita", LastName = " Krotov ", Age = 27, DepId = 4 }
            };



        }

    }

}