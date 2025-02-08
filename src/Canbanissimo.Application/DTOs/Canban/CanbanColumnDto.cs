using Canbanissimo.Application.DTOs.Common;

namespace Canbanissimo.Application.DTOs;

public class CanbanColumnDto : BaseDto
{
    public string Title { get; set; }
    public int Order { get; set; }
    public Guid BoardId { get; set; }
}