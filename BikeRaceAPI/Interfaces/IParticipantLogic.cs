using BikeRaceAPI.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.Interfaces
{
    public interface IParticipantLogic
    {
        Task<List<ParticipantDto>> GetParticipantsAsync();
        Task<ParticipantDto> GetParticipantAsync(Guid id);
        Task CreateParticipantAsync(ParticipantDto participant);
        Task EditParticipantAsync(ParticipantDto updatedParticipant);
        Task EditParticipantResultAsync(Guid id, ResultDto result);
        Task EditEntryFeeAsync(ParticipantDto participant);
        Task DeleteParticipantAsync(Guid id);
    }
}