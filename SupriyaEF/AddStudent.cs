using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaEF
{
    public class AddStudent
    {
        public void AddStudentItem(string name , int id)
        {
            EFContext context = new EFContext();
            Student s = new Student();
            s.Name = name;
            Course c = context.Courses.Where(iter => iter.courseId.Equals(id)).FirstOrDefault();
            ///context.Categories.Where(iter => iter.Name.Equals(category, StringComparison.OrdinalIgnoreCase)).Select(iter => iter.Id).FirstOrDefault();
            s.course = c;
            context.Students.Add(s);
            context.SaveChanges();
            Console.WriteLine("The Data is Updated Successfully");
        }
    }
}
