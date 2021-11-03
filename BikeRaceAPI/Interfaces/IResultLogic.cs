using BikeRaceAPI.DtoModels;
using BikeRaceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.Interfaces
{
    public interface IResultLogic
    {
        public Task<List<ResultDto>> GetResultsAsync();
        public Task<ResultDto> GetResultAsync(Guid id);
        public Task CreateResultAsync(ResultDto resultDto);
        public Task EditResultAsync(ResultDto resultDto);
        public Task DeleteResultAsync(Guid id);
    }
}