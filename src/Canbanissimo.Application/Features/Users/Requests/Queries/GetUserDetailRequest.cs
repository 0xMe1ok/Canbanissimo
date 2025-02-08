using Canbanissimo.Application.DTOs;
using MediatR;

namespace Canbanissimo.Application.Features.Users.Requests;

public class GetUserDetailRequest : IRequest<UserDto>
{
    public Guid Id { get; set; }
}