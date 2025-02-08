using Canbanissimo.Application.DTOs.Common;

namespace Canbanissimo.Application.DTOs;

public class CanbanBoardDto : BaseDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid GroupId { get; set; }
}