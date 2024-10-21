using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day4
{
    internal class Employee
    {
        public int empId {  get; set; }
        public string name {  get; set; }
        public string email { get; set; }
        public decimal salary { get; set; }

        public Employee(int empId , string name , string email , decimal salary)
        {
            this.empId = empId;
            this.name = name;
            this.email = email;
            this.salary = salary;
        }

        public void AddMovie(Movie movie , List<Movie> movieList)
        {
            if (movie == null)
            {
                Console.WriteLine("Invalid movie");
            }
            else
            {
                movieList.Add(movie);
                Console.WriteLine($"Employee {name} added the movie {movie.title}");
            }
        }
        public void DeleteMovie(Movie movie , List<Movie> movieList)
        {
            if (movie == null)
            {
                Console.WriteLine("Invalid movie");
            }
            else
            {
                movieList.Remove(movie);
                Console.WriteLine($"Employee {name} delete the movie {movie.title}");
            }
        }
        public void EditMovie(Movie movie, string title , int year , string genre , string director)
        {
            if (movie == null)
            {
                Console.WriteLine("Invalid movie");
            }
            else
            {
                movie.title = title;
                movie.year = year;
                movie.genre = genre;
                movie.director = director;
                Console.WriteLine($"Employee {name} edit the movie {movie.title}");
            }
        }

        public Movie searchMovie(string title , List<Movie> movieList)
        {
            return movieList.FirstOrDefault(x => x.title == title);
        }

        public bool checkAvailability(Movie movie)
        {
            if(movie == null)
            {
                Console.WriteLine("Movie is not found");
                return false;
            }
            return movie.checkAvailability();
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {empId}\nName: {name}\nEmail: {email}\nSalary: {salary}");
        }



    }
}
