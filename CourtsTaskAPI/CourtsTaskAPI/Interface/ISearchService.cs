using System;
using CourtsTaskAPI.Models;

namespace CourtsTaskAPI.Interface;

public interface ISearchService
{
   Task<List<TikModel>> IndexCasesAsync();
    Task<List<TikModel>> AdvancedSearchAsync(SearchCriteriaModel criteria);
}
