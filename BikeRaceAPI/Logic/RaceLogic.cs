using AutoMapper;
using BikeRaceAPI.DtoModels;
using BikeRaceAPI.Interfaces;
using BikeRaceAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.Logic
{
    public class RaceLogic : IRaceLogic
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public RaceLogic(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddParticipantToRaceAsync(Guid raceId, Guid participantId)
        {
            var race = await _context.Races.FirstOrDefaultAsync(r => r.Id == raceId);
            var participant = await _context.Participants.FirstOrDefaultAsync(p => p.Id == participantId);

            race.Participants.Add(participant);
            await _context.SaveChangesAsync();
        }

        public async Task CreateRaceAsync(RaceDto raceDto)
        {
            var race = _mapper.Map<RaceDto, Race>(raceDto);

            _context.Races.Add(race);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteParticipantFromRaceAsync(Guid raceId, Guid participantId)
        {
            var race = await _context.Races.FirstOrDefaultAsync(r => r.Id == raceId);
            var participant = await _context.Participants.FirstOrDefaultAsync(p => p.Id == participantId);

            race.Participants.Remove(participant);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRaceAsync(Guid id)
        {
            var race = await _context.Races.FirstOrDefaultAsync(r => r.Id == id);

            _context.Remove(race);
            await _context.SaveChangesAsync();
        }

        public async Task EditRaceAsync(RaceDto raceDto)
        {
            var race = await _context.Races.FirstOrDefaultAsync(r => r.Id == raceDto.Id);

            race.Name = raceDto.Name;
            race.Location = raceDto.Location;

            await _context.SaveChangesAsync();
        }

        public async Task<List<ParticipantDto>> GetAllParticipantsforRaceAsync(Guid raceId)
        {
            var race = await _context.Races.FirstOrDefaultAsync(r => r.Id == raceId);
            var mappedRace = _mapper.Map<Race, RaceDto>(race);

            return mappedRace.Participants.ToList();
        }

        public async Task<RaceDto> GetRaceAsync(Guid id)
        {
            var race = await _context.Races.FirstOrDefaultAsync(r => r.Id == id);
            var mappedRace = _mapper.Map<Race, RaceDto>(race);

            return mappedRace;
        }

        public async Task<List<TimeSpan>> GetRaceResultsAsync(Guid raceId)
        {
            var race = await _context.Races.FirstOrDefaultAsync(r => r.Id == raceId);
            var paricipantList = race.Participants.ToList();

            var timeResultsList = new List<TimeSpan>();
            foreach(var element in paricipantList)
            {
                if(element.Result.Time != null)
                {
                    timeResultsList.Add((TimeSpan)element.Result.Time);
                }
            }
            timeResultsList.OrderBy(t => t.TotalSeconds);

            return timeResultsList;
        }

        public async Task<List<RaceDto>> GetRacesAsync()
        {
            var races = await _context.Races.Include(p => p.Participants).ToListAsync();
            var mappedRaces = _mapper.Map<List<Race>, List<RaceDto>>(races);

            return mappedRaces;
        }
    }
}