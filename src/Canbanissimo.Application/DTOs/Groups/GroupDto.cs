using Canbanissimo.Application.DTOs.Common;

namespace Canbanissimo.Application.DTOs;

public class GroupDto : BaseDto
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public Guid CreatorId { get; private set; }
}