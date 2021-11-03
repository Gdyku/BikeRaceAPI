using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BikeRaceAPI.DtoModels;
using BikeRaceAPI.Interfaces;
using BikeRaceAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BikeRaceAPI.Logic
{
    public class ParticipantLogic : IParticipantLogic
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public ParticipantLogic(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateParticipantAsync(ParticipantDto participantDto)
        {
            var participant = _mapper.Map<ParticipantDto, Participant>(participantDto);

            _context.Participants.Add(participant);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteParticipantAsync(Guid id)
        {
            var participant = await _context.Participants.FirstOrDefaultAsync(p => p.Id == id);

            _context.Remove(participant);
            await _context.SaveChangesAsync();
        }

        public async Task EditEntryFeeAsync(ParticipantDto participantDto)
        {
            var participant = await _context.Participants.FirstOrDefaultAsync(p => p.Id == participantDto.Id);

            participant.Payed = participant.Payed;

            await _context.SaveChangesAsync();
        }

        public async Task EditParticipantAsync(ParticipantDto participantDto)
        {
            var participant = await _context.Participants.FirstOrDefaultAsync(p => p.Id == participantDto.Id);

            participant.Name = participantDto.Name;
            participant.Surname = participantDto.Surname;
            participant.Number = participantDto.Number;

            await _context.SaveChangesAsync();
        }

        public async Task EditParticipantResultAsync(Guid id, ResultDto resultDto)
        {
            var participant = await _context.Participants.FirstOrDefaultAsync(p => p.Id == id);

            participant.Result.Status = resultDto.Status;
            participant.Result.Time = resultDto.Time;

            await _context.SaveChangesAsync();
        }

        public async Task<ParticipantDto> GetParticipantAsync(Guid id)
        {
            var participant = await _context.Participants.FirstOrDefaultAsync(p => p.Id == id);
            var mappedParticipant = _mapper.Map<Participant, ParticipantDto>(participant);

            return mappedParticipant;
        }

        public async Task<List<ParticipantDto>> GetParticipantsAsync()
        {
            var participants = await _context.Participants.ToListAsync();
            var mappedParticipants = _mapper.Map<List<Participant>, List<ParticipantDto>>(participants);

            return mappedParticipants;
        }
    }
}