namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees : ");
            int size = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i+1}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary : ");
                double salary = double.Parse(Console.ReadLine());
                Console.Write("Hiring Day : ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("Hiring Month : ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Hiring Year : ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Gender (M/F) : ");
                char gender = char.Parse(Console.ReadLine().ToUpper());
                HiringDate hiringDate = new HiringDate(day ,month , year);
                employees[i] = new Employee(id, name, salary, hiringDate, gender);
            }
            // bubble sort
            for(int i = 0; i < size-1 ;i++)
            {
                for(int j = 1; j <= size - 1 -i;j++) 
                {
                    if (employees[i].HireDate.Earlierthan(employees[j].HireDate) == false)
                    {
                        Employee temp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted Employees based on Hire Date:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.DisplayEmployee());
            }
        }
    }
}
