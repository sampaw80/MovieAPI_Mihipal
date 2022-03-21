using MovieAPI.Models;
using System;
using System.Collections.Generic;

namespace MovieAPI.Interfaces
{
    public interface IMetadataService
    {
        List<MetaData> GetbyMovieId(int movieId);
        bool PostMetaData(MetaData metaData);
    }
}
