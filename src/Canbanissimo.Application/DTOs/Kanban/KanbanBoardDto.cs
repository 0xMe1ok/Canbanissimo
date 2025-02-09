using Canbanissimo.Application.DTOs.Common;

namespace Canbanissimo.Application.DTOs.Kanban;

public class KanbanBoardDto : BaseDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid GroupId { get; set; }
}