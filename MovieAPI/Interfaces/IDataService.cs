using MovieAPI.Models;
using System;
using System.Collections.Generic;

namespace MovieAPI.Interfaces
{
    public interface IDataService
    {
        public List<MetaData> ReadMetaData(string location);
        List<Stat> ReadStats(string path);
    }
}
