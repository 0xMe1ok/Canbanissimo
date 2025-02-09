using Canbanissimo.Application.DTOs.Common;

namespace Canbanissimo.Application.DTOs.Kanban;

public class KanbanColumnDto : BaseDto
{
    public string Title { get; set; }
    public int Order { get; set; }
    public Guid BoardId { get; set; }
}