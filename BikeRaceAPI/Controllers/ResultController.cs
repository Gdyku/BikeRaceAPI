using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeRaceAPI.Interfaces;
using BikeRaceAPI.DtoModels;

namespace BikeRaceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : Controller
    {
        private readonly IResultLogic _resultLogic;
        public ResultController(IResultLogic resultLogic)
        {
            _resultLogic = resultLogic;
        }

        [HttpGet("")]
        public async Task<List<ResultDto>> GetResultsAsync()
        {
            return await _resultLogic.GetResultsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ResultDto> GetResultAsync(Guid id)
        {
            return await _resultLogic.GetResultAsync(id);
        }

        [HttpPost]
        public async Task CreateResultAsync(ResultDto result)
        {
            await _resultLogic.CreateResultAsync(result);
        }

        [HttpPut("{id}")]
        public async Task EditResultAsync(ResultDto result)
        {
            await _resultLogic.EditResultAsync(result);
        }

        [HttpDelete("{id}")]
        public async Task DeleteResultAsync(Guid id)
        {
            await _resultLogic.DeleteResultAsync(id);
        }
    }
}