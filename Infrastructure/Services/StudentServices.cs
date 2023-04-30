namespace Infrastructure.Services;
using Domain.Models;

public class StudentServices
{
    List<Student> students;
    public StudentServices()
    {
        students = new List<Student>();
    }

    public List<Student> GetStudents()
    {
        return students;
    }
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public void UpdateStudent(int id, Student student)
    {
        foreach (var item in students)
        {
            if(item.Id == id) 
            {
                item.Firstname = student.Firstname;
                item.Lastname = student.Lastname;
                item.Address = student.Address;
                item.BirthDate = student.BirthDate;
            }
        }
    }
    public void Delete(int id)
    {
        foreach (var item in students)
        {
            if(item.Id == id) students.Remove(item);
        }
    }
}
