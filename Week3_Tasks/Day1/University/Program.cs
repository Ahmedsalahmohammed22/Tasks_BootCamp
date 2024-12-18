﻿using StudentLibrary;

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

            Console.WriteLine("Duration 3 before decrement");

            Duration D3 = new Duration(666);
            Console.WriteLine(D3);
            Console.WriteLine("Duration 3 after decrement");
            D3--;
            Console.WriteLine(D3.getstring());

            if (D1.Equals(D2))
            {
                Console.WriteLine("D1 equals D2");
            }
            else
            {
                Console.WriteLine("D1 notequals D2");
            }

            Console.WriteLine("Duration 4 before increment");
            Duration D4 = new Duration(5050);
            Console.WriteLine(D4.getstring());
            Console.WriteLine("Duration 4 after increment");
            D4++;
            Console.WriteLine(D4.getstring());


            Console.WriteLine($"{D4} <= {D1} : {D4 <= D1}");

;
        }
    }
}
