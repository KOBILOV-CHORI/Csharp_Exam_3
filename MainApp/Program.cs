using Infrastructure.Services;
using Domain.Models;

var st1 = new Student()
{
    Id = 1,
    Firstname = "Chori",
    Lastname = "Kobilov",
    Address = "Dushanbe",
    BirthDate = new DateTime(2007, 06, 01, 12, 45, 00)
};
var st2 = new Student()
{
    Id = 2,
    Firstname = "Chori",
    Lastname = "Kobilov",
    Address = "Dushanbe",
    BirthDate = new DateTime(2007, 06, 01, 12, 45, 00)
};
var st3 = new Student()
{
    Id = 3,
    Firstname = "Chori",
    Lastname = "Kobilov",
    Address = "Dushanbe",
    BirthDate = new DateTime(2007, 06, 01, 12, 45, 00)
};

var studentServices = new StudentServices(){};
studentServices.AddStudent(st1);
studentServices.AddStudent(st2);
studentServices.AddStudent(st3);

foreach (var item in studentServices.GetStudents())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Firstname);
    System.Console.WriteLine(item.Lastname);
    System.Console.WriteLine();
}