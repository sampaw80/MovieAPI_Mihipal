using System;
using CsvHelper.Configuration;

namespace MovieAPI.Models
{
    public sealed class MetaDataMap: ClassMap<MetaData>
    {
        public MetaDataMap()
        {
            Map(x => x.Id).Name("Id");
            Map(x => x.MovieId).Name("MovieId");
            Map(x => x.Title).Name("Title");
            Map(x => x.Language).Name("Language");
            Map(x => x.Duration).Name("Duration");
            Map(x => x.ReleaseYear).Name("ReleaseYear");
        }
    }
}
