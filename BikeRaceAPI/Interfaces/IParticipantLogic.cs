using BikeRaceAPI.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.Interfaces
{
    public interface IParticipantLogic
    {
        Task<List<ParticipantDto>> GetParticipants();
        Task<ParticipantDto> GetParticipant(Guid id);
        Task CreateParticipant(ParticipantDto participant);
        Task EditParticipant(ParticipantDto updatedParticipant);
        Task DeleteParticipant(Guid id);
    }
}
