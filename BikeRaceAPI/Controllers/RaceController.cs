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
    public class RaceController : Controller
    {
        private readonly IRaceLogic _raceLogic;
        public RaceController(IRaceLogic raceLogic)
        {
            _raceLogic = raceLogic;
        }

        [HttpGet]
        public async Task<List<RaceDto>> GetRacesAsync()
        {
            return await _raceLogic.GetRacesAsync();
        }

        [HttpGet("{id}")]
        public async Task<RaceDto> GetRaceAsync(Guid id)
        {
            return await _raceLogic.GetRaceAsync(id);
        }

        [HttpGet("participants/{raceId}")]
        public async Task<List<ParticipantDto>> GetRunnersForRaceAsync(Guid raceId)
        {
            return await _raceLogic.GetAllParticipantsforRaceAsync(raceId);
        }

        [HttpPost]
        public async Task CreateRaceAsync([FromBody]RaceDto race)
        {
            await _raceLogic.CreateRaceAsync(race);
        }

        [HttpPut("{id}")]
        public async Task EditRaceAsync([FromBody]RaceDto race)
        {
            await _raceLogic.EditRaceAsync(race);
        }

        [HttpPatch("participanttorace/{raceId}/{participantId}")]
        public async Task AddParticipantAsync(Guid raceId, Guid participantId)
        {
            await _raceLogic.AddParticipantToRaceAsync(raceId, participantId);
        }

        [HttpDelete("{id}")]
        public async Task DeleteRaceAsync(Guid id)
        {
            await _raceLogic.DeleteRaceAsync(id);
        }

        [HttpDelete("deleterunner/{id}")]
        public async Task DeleteParticipantFromRaceAsync(Guid raceId, Guid participantId)
        {
            await _raceLogic.DeleteParticipantFromRaceAsync(raceId, participantId);
        }

    }
}