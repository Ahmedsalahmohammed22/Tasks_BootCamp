namespace Day8_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************** Task 1 **********************");
            List<int> numbers = new List<int>() { 1 , 2 , 4 , 6 , 10 , 1 , 4 , 2 , 9 , 1};
            //Display numbers without any repeated Data and sorted  
            var q1 = numbers.Select(n => n).Distinct().Order();
            foreach (var n in q1)
            {
                Console.WriteLine(n);
                //show each number and it’s multiplication 
                Console.WriteLine($"Number  = {n}, Multiply = {n*n}");
            }
            Console.WriteLine("****************** Task 2 **********************");
            List<string> names = new List<string>() { "Tom" , "Dick" , "Harry" , "Mary" , "Jay"};
            //Select names with length equal 3. 
            var q2 = names.Where(name => name.Length == 3 ).ToList();
            foreach( var name in q2)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Select names that contains “a” letter (Capital or Small )then sort them by length ");
            var q3 = names.Where(name => name.Contains("a") || name.Contains("A")).OrderBy(name => name.Length);
            foreach( var name in q3)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Display the first 2 names ");
            var q4 = names.Select(name => name).Take(2);
            foreach( var name in q4)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("****************** Task 3 **********************");

            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    FirstName = "Ali",
                    LastName = "Mohammed",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 33, Name = "UML" }
                    }
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Mona",
                    LastName = "Gala",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 34, Name = "XML" },
                        new Subject() { Code = 25, Name = "JS" }
                    }
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Yara",
                    LastName = "Yousf",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 25, Name = "JS" }
                    }
                },
                new Student()
                {
                    Id = 4,
                    FirstName = "Ali",
                    LastName = "Ali",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 33, Name = "UML" }
                    }
                }
            };
            Console.WriteLine(" Display Full name and number of subjects for each student");
            foreach (Student student in students)
            {
                var obj = new { fullname = student.FirstName + " " + student.LastName , NoOfSubjects = student.Subjects.Count() };
                Console.WriteLine(obj);
            }
            Console.WriteLine("*************************");
            Console.WriteLine("Query which orders the elements in the list by FirstName Descending then by LastName Ascending and result of query displays only first names and last names for the elements in list ");
            var q5 = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName);
            foreach(var student in q5)
            {
                var FullName_Student = new { fullname = student.FirstName + " " + student.LastName };
                Console.WriteLine(FullName_Student.fullname);
            }



        }
    }
}
