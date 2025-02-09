using Canbanissimo.Domain.Common;
using Canbanissimo.Domain.Entities.Groups;

namespace Canbanissimo.Domain.Entities.Kanban;

public class KanbanBoard : BaseDomainEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; } // = DateTime.UtcNow;
    
    // Foreign keys
    public Guid GroupId { get; set; }  

    // Navigation
    public Group Group { get; set; }
    public List<KanbanColumn> Columns { get; set; }
}