using Canbanissimo.Application.DTOs;
using Canbanissimo.Domain.Entities.Users;
using MediatR;

namespace Canbanissimo.Application.Features.Users.Requests;

public class GetUserListRequest : IRequest<List<UserDto>>, IRequest
{
    
}