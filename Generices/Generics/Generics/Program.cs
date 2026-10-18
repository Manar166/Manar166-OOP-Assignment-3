namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericStore<Student> studentstore = new GenericStore<Student>( );
            studentstore.Add(new Student(1, "Ali"));
            studentstore.Add(new Student(2, "Mohamed"));
            studentstore.Add(new Student(3, "sara"));
            studentstore.Add(new Student(4, "Ahmed"));
            studentstore.Add(new Student(5, "yahia"));

            var student=studentstore.GetById(2);

            if (student != null)
            {
                Console.WriteLine($"Found Student -> ID: {student.Id}, Name: {student.Name}");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }

            Console.WriteLine("-----------------------------------------");

            GenericStore<Course> courseStore = new GenericStore<Course>();

            courseStore.Add(new Course  (101, "C# Basics" ,4247.3 ));
            courseStore.Add(new Course  (102, "Data Structures & Algorithms", 4244.3 ));
            courseStore.Add(new Course  (103, "Design Patterns", 4334.3 ));

            var course = courseStore.GetById(102);
            if (course != null)
            {
                Console.WriteLine($"Found Course -> ID: {course.Id}, Title: {course.Title}");
            }
            else
            {
                Console.WriteLine("Course not found!");
            }

            Console.WriteLine("\n-----------------------------------------");

            try
            {
                studentstore.Add(new Student(4, "faeew"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n-----------------------------------------");


            Console.WriteLine("--- Students Page 2 (Size 2) ---");

            var students = studentstore.GetAll().Values;

            IEnumerable<Student> res= students.Page<Student>(2, 2);

            foreach (var item in res)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}");
            }

            Console.WriteLine("\n-----------------------------------------");


            var plainCourses = new List<Course>();


            plainCourses.Add(new Course  (104, "C# " ,4247.3 ));
            plainCourses.Add(new Course  (105, " Algorithms", 4244.3 ));
            plainCourses.Add(new Course  (106, "Design ", 4334.3 ));
        

            int targetId = 104;
            var foundCourse = plainCourses.FindById(targetId);

            
            if (foundCourse != null)
            {
                Console.WriteLine($"Found Course -> ID: {foundCourse.Id}, Title: {foundCourse.Title}");
            }
            else
            {
                Console.WriteLine("Course not found!");
            }



            //new GenericStore<string>();



        }
    }
}
