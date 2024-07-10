using AutoMapper;
using DebtTrack.Application.Features.AuthFeatures.LoginFeatures;
using DebtTrack.Application.Features.AuthFeatures.RegisterFeatures;
using DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;
using DebtTrack.Application.Features.ParticipantFeatures.Command;
using DebtTrack.Application.Features.UserFeatures.Command.UpdateUser;
using DebtTrack.Application.Features.UserFeatures.Query.GetAll;
using DebtTrack.Application.Features.UserFeatures.Query.GetById;
using DebtTrack.Application.Features.UserFeatures.Query.GetByUsername;
using DebtTrack.Domain.Entities;

namespace DebtTrack.Application
{
    public class AutoMapperProfilling : Profile
    {
        public AutoMapperProfilling()
        {
            SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            DestinationMemberNamingConvention = new PascalCaseNamingConvention();

            CreateMap<UpdateUserRequest, User>();
            CreateMap<User, UpdateUserResponse>();

            CreateMap<GetAllUserRequest, User>();
            CreateMap<User, GetAllUserResponse>();            
            
            CreateMap<GetByIdUserRequest, User>();
            CreateMap<User, GetByIdUserResponse>();            
            
            CreateMap<GetByUsernameRequest, User>();
            CreateMap<User, GetByUsernameResponse>();

            CreateMap<RegisterRequest, User>();
            CreateMap<User, RegisterResponse>();

            CreateMap<LoginRequest, User>();
            CreateMap<User, LoginResponse>();            

            CreateMap<Participant, GetAllParticipantResponse>();
            CreateMap<Participant, GetByIdParticipantResponse>();

            CreateMap<CreateParticipantRequest, Participant>();
            CreateMap<Participant, CreateParticipantResponse>();
            
            CreateMap<UpdateParticipantRequest, Participant>();
            CreateMap<Participant, UpdateParticipantResponse>();
            
            CreateMap<CreateTransactionRequest, Transaction>();
            CreateMap<Transaction, CreateTransactionResponse>();
        }
    }
}
