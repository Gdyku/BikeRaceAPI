using BikeRaceAPI.DtoModels;
using BikeRaceAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantController : Controller
    {
        private readonly IParticipantLogic _participantLogic;
        public ParticipantController(IParticipantLogic participantLogic)
        {
            _participantLogic = participantLogic;
        }

        [HttpGet("")]
        public async Task<List<ParticipantDto>> GetParticipantsAsync()
        {
            return await _participantLogic.GetParticipantsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ParticipantDto> GetParticipantAsync(Guid id)
        {
            return await _participantLogic.GetParticipantAsync(id);
        }

        [HttpPost("")]
        public async Task CreateParticipantAsync(ParticipantDto participantDto)
        {
            await _participantLogic.CreateParticipantAsync(participantDto);
        }

        [HttpPatch("fee/{id}")]
        public async Task EditRunnerFeeAsync(ParticipantDto participant)
        {
            await _participantLogic.EditEntryFeeAsync(participant);
        }

        [HttpPatch("result/{id}")]
        public async Task EditRunnerResultAsync(Guid id, ResultDto resultDto)
        {
            await _participantLogic.EditParticipantResultAsync(id, resultDto);
        }

        [HttpPut("{id}")]
        public async Task EditParticipantAsync(ParticipantDto participantDto)
        {
            await _participantLogic.EditParticipantAsync(participantDto);
        }

        [HttpDelete("{id}")]
        public async Task DeleteParticipantAsync(Guid id)
        {
            await _participantLogic.DeleteParticipantAsync(id);
        }
    }
}