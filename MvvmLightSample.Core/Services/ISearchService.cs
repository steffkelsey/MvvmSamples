﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MvxSample.Core.Models;

namespace MvvmLightSample.Core.Services
{
    public enum SearchProvider
    {
        Searx,
        DuckDuckGo
    }

    public interface ISearchService
    {
        Task<IEnumerable<SearchResult>> QueryAsync(string query, SearchProvider provider);
    }
}
