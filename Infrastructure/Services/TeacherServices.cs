namespace Infrastructure.Services;
using Domain.Models;

public class TeacherServices
{
        List<Teacher> teachers;
    public TeacherServices()
    {
        teachers = new List<Teacher>();
    }

    public List<Teacher> Getteachers()
    {
        return teachers;
    }
    public void Addteacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }
    public void Updateteacher(int id, Teacher teacher)
    {
        foreach (var item in teachers)
        {
            if(item.Id == id) 
            {
                item.Firstname = teacher.Firstname;
                item.Lastname = teacher.Lastname;
                item.Position = teacher.Position;
                item.ExperienceAmount = teacher.ExperienceAmount;
            }
        }
    }
    public void Delete(int id)
    {
        foreach (var item in teachers)
        {
            if(item.Id == id) teachers.Remove(item);
        }
    }
}
