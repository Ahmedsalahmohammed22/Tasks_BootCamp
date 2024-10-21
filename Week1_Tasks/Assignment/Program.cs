namespace Assignment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            int x, y, Operator;
            Console.WriteLine("Please Enter the first number : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the second number : ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here are the options : \r\n1-Addition. \r\n2-Substraction.\r\n3-Multiplication\r\n4-Division.\r\n5-Exit.");
            Console.WriteLine("Input your choice :");
            Operator = Convert.ToInt32(Console.ReadLine());
            switch (Operator)
            {
                case 1:
                    Console.WriteLine("The Addition of " + x + " and " + y + " is: " + (x + y));
                    break;
                case 2:
                    Console.WriteLine("The Substraction of " + x + " and " + y + " is: " + (x - y));
                    break;
                case 3:
                    Console.WriteLine("The Multiplication of " + x + " and " + y + " is: " + (x * y));
                    break;
                case 4:
                    Console.WriteLine("The Division of " + x + " and " + y + " is: " + (x / y));
                    break;
                case 5:
                    Console.WriteLine("The programs is Exit");
                    break;
                default:
                    Console.WriteLine("Please Enter correct number");
                    break;
            }











        }
    }
}
