using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaEF
{
    public class ViewStudents
    {
        public void ViewStudentItems()
        {
            EFContext context = new EFContext();
            var query = from studentItem in context.Students
                        select new
                        {
                            studentItem.studentId,
                            studentItem.Name,
                            studentItem.course
                        };
            foreach(var item in query.ToList())
            {
                Console.WriteLine("{0} {1} {2}", item.studentId, item.Name.ToString(), item.course.CourseName.ToString());
            }
        }
    }
}
