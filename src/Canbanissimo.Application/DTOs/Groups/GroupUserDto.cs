using Canbanissimo.Application.DTOs.Common;
using Canbanissimo.Application.Enum;

namespace Canbanissimo.Application.DTOs;

public class GroupUserDto : BaseDto
{
    public Guid UserId { get; set; }
    public Guid GroupId { get; set; }
    public GroupRole Role { get; set; }
}