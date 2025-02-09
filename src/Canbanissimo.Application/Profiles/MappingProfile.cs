using AutoMapper;
using Canbanissimo.Application.DTOs;
using Canbanissimo.Application.DTOs.Kanban;
using Canbanissimo.Domain.Entities.Groups;
using Canbanissimo.Domain.Entities.Users;
using Canbanissimo.Domain.Entities.Kanban;

namespace Canbanissimo.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Group, GroupDto>().ReverseMap();
        CreateMap<GroupUser, User>().ReverseMap();
        CreateMap<KanbanBoard, KanbanBoardDto>().ReverseMap();
        CreateMap<KanbanColumn, KanbanColumnDto>().ReverseMap();
        CreateMap<KanbanTask, KanbanTaskDto>().ReverseMap();
    }
}