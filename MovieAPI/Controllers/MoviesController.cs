using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Interfaces;
using MovieAPI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private IMovieService _movieService;
        private IDataService _dataService;
        public MoviesController(IMovieService movieService,IDataService dataService)
        {
            _movieService = movieService;
            _dataService = dataService;
        }

        [HttpGet("stats")]
        public IActionResult Getstats()
        {
            try
            {
                List<Stat> stats = _movieService.Getstats();
           
                return Ok(stats);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
