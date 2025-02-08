using AutoMapper;
using Canbanissimo.Application.DTOs;
using Canbanissimo.Domain.Entities.Groups;
using Canbanissimo.Domain.Entities.Users;
using Canbanissimo.Domain.Entities.Canban;

namespace Canbanissimo.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Group, GroupDto>().ReverseMap();
        CreateMap<GroupUser, User>().ReverseMap();
        CreateMap<CanbanBoard, CanbanBoardDto>().ReverseMap();
        CreateMap<CanbanColumn, CanbanColumnDto>().ReverseMap();
        CreateMap<CanbanTask, CanbanTaskDto>().ReverseMap();
    }
}