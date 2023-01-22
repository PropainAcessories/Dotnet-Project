using System;

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
    static void PrintEmployees(List<Employee> employees)
    {
      for (int i = 0; i < employees.Count; i++)
      {
        // Dictates layout of text/images.
        string template = "{0,-10}\t{1,-20}\t{2}";
        Console.WriteLine(String.Format(template, employees[i].getId(), employees[i].GetFullName(), employees[i].getPhotoUrl()));
      }
    }
    static void Main(string[] args)
    {
      List<Employee> employees = GetEmployees();
      PrintEmployees(employees);
    }
  }
}
