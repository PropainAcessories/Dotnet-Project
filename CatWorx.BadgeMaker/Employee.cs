namespace CatWorx.BadgeMaker
{
  class Employee
  {
    private string FirstName;
    private string LastName;
    private int Id;
    private string PhotoUrl;

    public Employee(string firstName, string lastName, int id, string photoUrl) {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        PhotoUrl = photoUrl;
    }
    public string GetFullName() {
        return  FirstName + " " + LastName;
    }

    public int getId() {
        return Id;
    }

    public string GetCompanyName() {
      return "Cat Worx";
    }

    public string getPhotoUrl() {
        return PhotoUrl;
    }
  }
}
