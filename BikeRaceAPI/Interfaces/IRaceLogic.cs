using BikeRaceAPI.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.Interfaces
{
    public interface IRaceLogic
    {
        Task<List<RaceDto>> GetRaces();
        Task<RaceDto> GetRace(Guid id);
        Task CreateRace(RaceDto race);
        Task EditRace(RaceDto race);
        Task DeleteRace(Guid id);
    }
}
