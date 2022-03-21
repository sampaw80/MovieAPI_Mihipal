using System;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Interfaces;
using MovieAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    public class MetaDataController : Controller
    {
        private IMetadataService _metadataService;
        public MetaDataController(IMetadataService metadataService)
        {
            _metadataService = metadataService;
        }

        // GET api/values/5
        [HttpGet("{movieId}")]
        public IActionResult Get(int movieId)
        {
            try
            {
                var MetaForMovie = _metadataService.GetbyMovieId(movieId);
                return Ok(MetaForMovie);
            }
            catch(Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
                     
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post(MetaData metaData)
        {
            try
            {
                bool issuccess = _metadataService.PostMetaData(metaData);
                return Ok(issuccess);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
