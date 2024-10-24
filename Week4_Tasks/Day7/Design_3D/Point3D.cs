using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_3D
{
    class InvalidCoordinateException : Exception
    {
        public InvalidCoordinateException(string mssg) : base(mssg)
        {
            
        }
    }
    internal class Point3D
    {
        int? x, y, z;
        public int? X {
            get { return x; }
            set
            {
                if (!value.HasValue)
                {
                    throw new InvalidCoordinateException("X coordinate cannot be null.");
                }
                x = value;
            }
        }
        public int? Y {
            get { return y; }
            set
            {
                if (!value.HasValue)
                {
                    throw new InvalidCoordinateException("Y coordinate cannot be null.");
                }
                y = value;
            }
        }
        public int? Z {
            get { return z; }
            set
            {
                if (!value.HasValue)
                {
                    throw new InvalidCoordinateException("Z coordinate cannot be null.");
                }
                z = value;
            }
        }
        public Point3D(int? x , int? y , int? z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"Point3D({X}, {Y}, {Z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point3D other)
            {
                return X == other.X && Y == other.Y && Z == other.Z;
            }
            return false;
        }
        public static bool operator ==(Point3D a, Point3D b)
        {
            if(a is null &&  b is null) return true;
            if( a is null || b is null ) return false;
            return a.Equals(b);
        }
        public static bool operator !=(Point3D a, Point3D b) 
        { 
            return !(a == b); 
        }
        public static List<Point3D> ReadfromFile(string file)
        {
            List<Point3D> points = new List<Point3D>();
            if(File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                foreach(string line in lines)
                {
                    string[] point = line.Split(",");
                    if(point.Length == 3 ) 
                    {
                        int x = int.Parse(point[0]);
                        int y = int.Parse(point[1]);
                        int z = int.Parse(point[2]);       
                        points.Add(new Point3D(x, y, z));
                    }


                }

            }
            return points;
        }
        public static void DeleteFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine($"{fileName} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"{fileName} does not exist.");
            }
        }

        public static bool SearchInFile(Point3D point, string fileName)
        {
            var points = ReadfromFile(fileName);
            return points.Contains(point);
        }


    }
}
