using System;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    async static Task Main(string[] args)
    {
      Console.WriteLine("Do you Want to use the API? type 'Yes' or 'No' for manual input");
      string response = Console.ReadLine() ?? "";
      if (response == "Yes")
      {
        List <Employee> autoEmployees = await PeopleFetcher.GetFromApi();
        Util.PrintEmployees(autoEmployees);
        Util.checkData(autoEmployees);
        await Util.MakeBadges(autoEmployees);
      } else if (response == "No")
      {
        List<Employee> employees = PeopleFetcher.GetEmployees();
        Util.PrintEmployees(employees);
        Util.checkData(employees);
        await Util.MakeBadges(employees);
      }
    }
  }
}
