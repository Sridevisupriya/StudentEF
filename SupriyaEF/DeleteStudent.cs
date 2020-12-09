using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SupriyaEF
{
    public class DeleteStudent
    {
        public void DeleteStudentItem(int id)
        {
            EFContext context = new EFContext();
            var query = from studentItem in context.Students
                        where studentItem.studentId == id
                        select studentItem;
            if(query==null)
            {
                Console.WriteLine("No Rows are there with same id");
            }
            else
            {
                foreach(var item in query.ToList())
                {
                    context.Students.Remove(item);
                    context.SaveChanges();
                    Console.WriteLine("Deleted Successfully");

                }
            }
        }
    }
}
