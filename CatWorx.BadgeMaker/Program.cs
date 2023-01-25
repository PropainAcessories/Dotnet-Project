using System;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static List<Employee> GetEmployees()
    {
      List<Employee> employees = new List<Employee>();
      while (true)
      {
        Console.WriteLine("Please enter first name:");
        string firstName = Console.ReadLine() ?? "";
        //Stops running upon pressing enter with no input.
        if (firstName == "")
        {
          break;
        }

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine() ?? "";

        Console.Write("Enter ID number: ");
        int id = Int32.Parse(Console.ReadLine() ?? "");

        Console.Write("Enter Photo URL:");
        string photoUrl = Console.ReadLine() ?? "";

        Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
        employees.Add(currentEmployee);
      }
      // Return Statement.
      return employees;
    }
    async static Task Main(string[] args)
    {
      List<Employee> employees = GetEmployees();
      Util.PrintEmployees(employees);
      Util.checkData(employees);
      await Util.MakeBadges(employees);
    }
  }
}
