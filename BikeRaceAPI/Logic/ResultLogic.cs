using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BikeRaceAPI.DtoModels;
using BikeRaceAPI.Interfaces;
using BikeRaceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeRaceAPI.Logic
{
    public class ResultLogic : IResultLogic
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public ResultLogic(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreateResultAsync(ResultDto resultDto)
        {
            var mappedResult = _mapper.Map<ResultDto, Result>(resultDto);

            _context.Results.Add(mappedResult);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteResultAsync(Guid id)
        {
            var result = await _context.Results.FirstOrDefaultAsync(r => r.Id == id);

            _context.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task EditResultAsync(ResultDto resultDto)
        {
            var result = await _context.Results.FirstOrDefaultAsync(r => r.Id == resultDto.Id);

            result.Status = resultDto.Status;
            result.Time = resultDto.Time;

            await _context.SaveChangesAsync();
        }

        public async Task<ResultDto> GetResultAsync(Guid id)
        {
            var result = await _context.Results.FirstOrDefaultAsync(r => r.Id == id);
            var mappedResult = _mapper.Map<Result, ResultDto>(result);

            return mappedResult;
        }

        public async Task<List<ResultDto>> GetResultsAsync()
        {
            var results = await _context.Results.ToListAsync();
            var mappedResults = _mapper.Map<List<Result>, List<ResultDto>>(results);

            return mappedResults;
        }
    }
}