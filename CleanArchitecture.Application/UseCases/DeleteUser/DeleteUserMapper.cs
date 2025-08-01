using AutoMapper;
using Domain.Entities;

namespace CleanArchitecture.Application.UseCases.DeleteUser;

public sealed class DeleteUserMapper : Profile
{
    public DeleteUserMapper()
    {
        CreateMap<DeleteUserRequest, User>();
        CreateMap<User, DeleteUserResponse>();
    }
}