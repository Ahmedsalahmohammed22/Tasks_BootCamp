namespace Design_3D
{
    internal class Program
    {
        static Point3D ReadPoint(string message)
        {
            bool flag = false;
            int x , y = 0, z = 0;
            Console.WriteLine(message);
            do
            {
                Console.WriteLine("Enter X coordinate");
                flag = int.TryParse(Console.ReadLine(), out x);
                if (!flag)
                {
                    Console.WriteLine("Invalid input for X coordinate. Please enter a valid integer.");
                }
            } while (flag == false);
            try
            {
                Console.WriteLine("Enter Y coordinate");
                y = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                StreamWriter stream = File.AppendText("errors.log");
                stream.WriteLine($"{ex.Message} - {ex.Source} - {ex.TargetSite} - {DateTime.Now}");
                Console.WriteLine(ex.Message);
                stream.Close();
            }

            try
            {
                Console.WriteLine("Enter Z coordinate :");
                z = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            return new Point3D(x, y, z);
        }

        static void Main(string[] args)
        {
            try
            {
                Point3D point1 = new Point3D(10, 20, 30);
                Console.WriteLine(point1);
 
                Point3D point4 = new Point3D(10, 25, 30);
                Console.WriteLine(point4);
                Console.WriteLine(point1 == point4);



                Point3D point3 = new Point3D(null, 10, 15);
                Console.WriteLine(point3);

            }
            catch (InvalidCoordinateException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Point3D userPoint = ReadPoint("Enter the coordinates for a point:");
            Console.WriteLine($"You entered: {userPoint}");


        }
    }
}
