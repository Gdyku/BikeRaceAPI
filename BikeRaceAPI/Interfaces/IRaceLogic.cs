using BikeRaceAPI.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.Interfaces
{
    public interface IRaceLogic
    {
        Task<List<RaceDto>> GetRacesAsync();
        Task<List<ParticipantDto>> GetAllParticipantsforRaceAsync(Guid raceId);
        Task<List<TimeSpan>> GetRaceResultsAsync(Guid raceId);
        Task<RaceDto> GetRaceAsync(Guid raceId);
        Task AddParticipantToRaceAsync(Guid raceId, Guid participantId);
        Task CreateRaceAsync(RaceDto race);
        Task EditRaceAsync(RaceDto race);
        Task DeleteRaceAsync(Guid raceId);
        Task DeleteParticipantFromRaceAsync(Guid raceId, Guid participantId);
    }
}