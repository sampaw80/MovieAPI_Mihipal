using System;
using CsvHelper.Configuration;

namespace MovieAPI.Models
{
    public sealed class StatMap : ClassMap<Stat>
    {
        public StatMap() { 
        Map(x => x.MovieId).Name("movieId");
        Map(x => x.AverageWatchDurationS).Name("watchDurationMs");
        }
    }
 }   