using MovieAPI.Models;
using System;
using System.Collections.Generic;

namespace MovieAPI.Interfaces
{
    public interface IMovieService
    {
        List<Stat> Getstats();
    }
}
