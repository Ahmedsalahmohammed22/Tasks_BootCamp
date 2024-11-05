using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsAPI_Task.Models;

namespace NewsAPI_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        static List<News> nws = new List<News>()
        {
           new  News(){Id=1,Title="Soccer Championship",Description="Highlights and analysis of the recent soccer championship.",Authorname="Ahmed"},
           new  News(){Id=2,Title="Health and Wellness Tips",Description="Top health and wellness tips for maintaining a balanced lifestyle.",Authorname="Ahmed"},
           new  News(){Id=3,Title="Global Economic Trends",Description="An in-depth analysis of the current economic trends worldwide.",Authorname="Khaled"},
           new  News(){Id=4,Title="Advancements in Renewable Energy",Description="New solar and wind power technologies are paving the way for a cleaner future.",Authorname="Mohammed"},
           new  News(){Id=5,Title="Top Travel Destinations 2024",Description="Explore the top travel destinations for 2024 and plan your next adventure.",Authorname="Yasser"},
           new  News(){Id=6,Title="Tips for Financial Planning",Description="Essential financial planning tips to help you manage your money effectively.",Authorname="Khaled"},
        };
        [HttpGet]
        public IActionResult getAllNews()
        {
            if(nws.Count == 0)
            {
                return NoContent();
            }
            return Ok(nws);
        }
        [HttpGet("{id:int}")]
        public IActionResult getNews(int id)
        {
            var news = nws.Where(n => n.Id == id).SingleOrDefault();
            if (news == null) return NotFound();
            return Ok(news);
        }
        [HttpGet("/author/{name:alpha}")]
        public IActionResult getAuthor(string name)
        {
            var auth = nws.Where(a => a.Authorname == name).ToList();
            if (auth == null) return NotFound();
            return Ok(auth);
        }
        [HttpPost]
        public IActionResult addNews(News news)
        {
            if(news == null) return BadRequest();
            nws.Add(news);
            return Created();
        }
        [HttpPut("id")]
        public IActionResult updateNews(int id , News news)
        {
            if (news == null) return BadRequest();
            News nw = nws.Where(n => n.Id == id).SingleOrDefault();
            if (nw == null) return NotFound();
            nw.Id = news.Id;
            nw.Title = news.Title;
            nw.Description = news.Description;
            nw.Authorname = news.Authorname;
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteNews(int id)
        {
            News nw = nws.Where(n => n.Id==id).SingleOrDefault();
            if (nw == null) return NotFound();
            nws.Remove(nw);
            return Ok(nws);
        }
    }
}
