using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaEF
{
    public class ViewCourses
    {
        public void ViewCourseItems()
        {
            EFContext context = new EFContext();
            var query = from courseItem in context.Courses
                        select new
                        {
                            courseItem.courseId,
                            courseItem.CourseName,
                            courseItem.Description
                        };

            foreach(var item in query.ToList())
            {
                Console.WriteLine("{0} {1} {2}", item.courseId, item.CourseName.ToString(), item.Description.ToString());
            }
         }
        
    }
}
