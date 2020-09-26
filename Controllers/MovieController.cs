using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using capstone.Data;
using capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace capstone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private ApplicationDbContext _context;

        public MovieController(ApplicationDbContext context) {
            _context = context;
        }


        //get method with authenticated user
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            return _context.Movies.Where(m => m.UserId == userId);
        }

        [HttpPost]
        public Movie Post([FromBody]Movie movie)
        {
            movie.UserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _context.Movies.Add(movie);
            _context.SaveChanges();

            return movie;
        }
    }
}
