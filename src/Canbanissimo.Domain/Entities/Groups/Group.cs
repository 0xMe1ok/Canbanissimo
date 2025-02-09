using Canbanissimo.Domain.Common;
using Canbanissimo.Domain.Entities.Kanban;
using Canbanissimo.Domain.Entities.Users;

namespace Canbanissimo.Domain.Entities.Groups;

public class Group : BaseDomainEntity
{
    public string Title { get; set; }
    
    // Foreign keys
    public Guid CreatorId { get; set; }

    // Navigation
    public User Creator { get; set; }
    public List<GroupUser> GroupUsers { get; set; }
    public List<KanbanBoard> Boards { get; set; } 
}