using Canbanissimo.Application.DTOs.Common;
using MediatR;

namespace Canbanissimo.Application.DTOs;

public class UserDto : BaseDto, IRequest
{
    public string Name { get; set; }
    public string Email { get; set; }
}