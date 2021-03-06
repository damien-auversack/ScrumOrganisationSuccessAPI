using System.Collections.Generic;
using Application.UseCases.Participation.Dtos;
using Application.UseCases.Utils;
using Infrastructure.SqlServer.Repositories.Participation;

namespace Application.UseCases.Participation.Get
{
    public class UseCaseGetAllParticipations : IQuery<List<OutputDtoParticipation>>
    {

        private readonly IParticipationRepository _participationRepository;

        public UseCaseGetAllParticipations(IParticipationRepository participationRepository)
        {
            _participationRepository = participationRepository;
        }
        
        public List<OutputDtoParticipation> Execute()
        {
            var participation = _participationRepository.GetAll();

            return Mapper.GetInstance().Map<List<OutputDtoParticipation>>(participation);
        }
    }
}