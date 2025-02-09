using Canbanissimo.Application.DTOs.Common;
using Canbanissimo.Application.Enum;

namespace Canbanissimo.Application.DTOs.Kanban;

public class KanbanTaskDto : BaseDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Order { get; set; }
    public DateTime CreatedAt { get; }
    public DateTime? DueDate { get; set; }
    public TaskPriority Priority { get; set; }
    
    public Guid ColumnId { get; set; }
    public Guid CreatorId { get; set; }
    public Guid? AssigneeId { get; set; }
}