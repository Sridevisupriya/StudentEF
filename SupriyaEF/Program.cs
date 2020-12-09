using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupriyaEF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 1.Add Student 2.View Courses 3.View Students 4.Delete Student");
                int option = int.Parse(Console.ReadLine());
                if (option == 2)
                {
                    Console.WriteLine("The Option Chosen is View Courses");
                    ViewCourses vc = new ViewCourses();
                    vc.ViewCourseItems();
                }
                else if (option == 1)
                {
                    Console.WriteLine("The Option Chosen is Add Student");
                    Console.WriteLine("Enter the Student Name");
                    string name = Console.ReadLine();
                    ViewCourses vc = new ViewCourses();
                    vc.ViewCourseItems();
                    Console.WriteLine("Enter the Course Id from above List");
                    int id = int.Parse(Console.ReadLine());
                    AddStudent ads = new AddStudent();
                    ads.AddStudentItem(name, id);

                }
                else if (option == 3)
                {
                    Console.WriteLine("The Option Chosen is View Students");
                    ViewStudents vis = new ViewStudents();
                    vis.ViewStudentItems();
                }
                else if (option == 4)
                {
                    Console.WriteLine("The Option Chosen is Delete Student");
                    Console.WriteLine("Enter the Student Id which u want to delete");
                    int id = int.Parse(Console.ReadLine());
                    DeleteStudent dsvar = new DeleteStudent();
                    dsvar.DeleteStudentItem(id);
                    ViewStudents vis = new ViewStudents();
                    vis.ViewStudentItems();
                }
                else
                {
                    Console.WriteLine("Other Option choosen");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
