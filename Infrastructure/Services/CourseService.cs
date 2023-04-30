namespace Infrastructure.Services;
using Domain.Models;

public class CourseService
{
    List<Course> courses;

    public CourseService()
    {
        courses = new List<Course>();
    }

    public List<Course> GetCourses()
    {
        return courses;
    }
    public void AddCourse(Course Course)
    {
        courses.Add(Course);
    }
    public void UpdateCourse(int id, Course Course)
    {
        foreach (var item in courses)
        {
            if(item.Id == id) 
            {
                item.Title = Course.Title;
                item.Description = Course.Description;
                item.Fee = Course.Fee;
                item.HasDiscount = Course.HasDiscount;
            }
        }
    }
    public void Delete(int id)
    {
        foreach (var item in courses)
        {
            if(item.Id == id) courses.Remove(item);
        }
    }
}
