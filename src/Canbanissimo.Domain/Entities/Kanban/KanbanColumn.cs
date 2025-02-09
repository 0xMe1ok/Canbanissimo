using Canbanissimo.Domain.Common;

namespace Canbanissimo.Domain.Entities.Kanban;

public class KanbanColumn : BaseDomainEntity
{
    public string Title { get; set; }
    public int Order { get; set; }
    public Guid BoardId { get; set; }
    
    // Navigation
    public KanbanBoard KanbanBoard { get; }
    public List<KanbanTask> Tasks { get; set; }
}