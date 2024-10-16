using StudentLibrary;

namespace University
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var student = new Student(1, "Ahmed", 23, "ahmed@gmail.com", "01011121505", "ST", "IT");
            //Console.WriteLine(student.DisplayInfo());

            Duration D1 = new Duration(1, 10, 15);
            D1.getstring();

            Duration D2 = new Duration(3600);
            Console.WriteLine( D2.getstring() );

            Duration D3 = new Duration(666);
            Console.WriteLine(D3);

            if(D1.Equals(D2))
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine("notequals");
            }

            Duration D4 = new Duration(5050);
            Console.WriteLine(D4.getstring());

            Console.WriteLine($"{D4} <= {D1} : {D4 <= D1}");

;
        }
    }
}
