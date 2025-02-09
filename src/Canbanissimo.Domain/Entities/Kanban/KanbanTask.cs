using Canbanissimo.Domain.Common;
using Canbanissimo.Domain.Entities.Users;
using Canbanissimo.Domain.Enum;

namespace Canbanissimo.Domain.Entities.Kanban;

public class KanbanTask : BaseDomainEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Order { get; set; }
    public DateTime CreatedAt { get; set; } // = DateTime.UtcNow;
    public DateTime? DueDate { get; set; }  
    public TaskPriority Priority { get; set; } // = TaskPriority.Low;

    // Foreign keys
    public Guid ColumnId { get; set; }
    public Guid CreatorId { get; set; }  
    public Guid? AssigneeId { get; set; }  

    // Navigation
    public KanbanColumn Column { get; set; }
    public User Creator { get; set; }
    public User? Assignee { get; set; }
}

