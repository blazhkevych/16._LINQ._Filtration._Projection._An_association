namespace task;

/// <summary>
///     Фильтрация. Проецирование. Объединение.
///     1) Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Одессе.
///     2) Вывести список стран без повторений.
///     3) Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет.
///     4) Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает 23 года.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        var departments = new List<Department>
        {
            new() { Id = 1, Country = "Ukraine", City = "Lviv" },
            new() { Id = 2, Country = "Ukraine", City = "Kyiv" },
            new() { Id = 3, Country = "France", City = "Paris" },
            new() { Id = 4, Country = "Ukraine", City = "Odesa" }
        };

        var employees = new List<Employee>
        {
            new() { Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },
            new() { Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
            new() { Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
            new() { Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
            new() { Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
            new() { Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
            new() { Id = 7, FirstName = "Nikita", LastName = " Krotov ", Age = 27, DepId = 4 }
        };

        // Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Одессе.
        var query1 = from employee in employees
            join department in departments on employee.DepId equals department.Id
            where department.Country == "Ukraine" && department.City != "Odesa"
            select new { employee.FirstName, employee.LastName };
        // Вывод в консоль.
        Console.WriteLine("1) Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Одессе.");
        foreach (var item in query1) Console.WriteLine(item);

        // Вывести список стран без повторений.
        var query2 = from department in departments
            select department.Country;
        // Вывод в консоль.
        Console.WriteLine("2) Вывести список стран без повторений.");
        foreach (var item in query2.Distinct()) Console.WriteLine(item);

        // Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет.
        var query3 = from employee in employees
            where employee.Age > 25
            select employee.FirstName + " " + employee.LastName;
        // Вывод в консоль.
        Console.WriteLine("3) Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет.");
        foreach (var item in query3.Take(3)) Console.WriteLine(item);

        // Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает 23 года.
        var query4 = from employee in employees
            join department in departments on employee.DepId equals department.Id
            where department.City == "Kyiv" && employee.Age > 23
            select new { employee.FirstName, employee.LastName, employee.Age };
        // Вывод в консоль.
        Console.WriteLine("4) Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает 23 года.");
        foreach (var item in query4) Console.WriteLine(item);
    }
}