using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day4
{
    internal class Movie
    {
        public int movieId {  get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public string director { get; set; }
        public bool isAvailable { get; set; }
        public decimal pricePerDay { get; set; }

        public Movie(int movieId , string title , int year , string genre , string director , bool isAvailable , decimal pricePerDay)
        {
            this.movieId = movieId;
            this.title = title;
            this.year = year;
            this.genre = genre;
            this.director = director;
            this.isAvailable = isAvailable;
            this.pricePerDay = pricePerDay;
        }
        public bool checkAvailability()
        {
            return this.isAvailable;
        }
        public void RentMovie()
        {
            if(this.isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"{title} has been rented");
            }
            else
            {
                Console.WriteLine($"{title} is not available");
            }
        }
        public void returnMovie()
        {
            isAvailable= true;
            Console.WriteLine($"{title} has been returned");
        }
        public void displayDetails()
        {
            Console.WriteLine($"\"Movie ID: {movieId}\\nTitle: {{title}}\\nYear: {{year}}\\nGenre: {{genre}}\\nDirector: {{director}}\\nAvailable: {{isAvailable}}");
        }

    }
}
