using Canbanissimo.Domain.Common;
using Canbanissimo.Domain.Entities.Canban;
using Canbanissimo.Domain.Entities.Users;

namespace Canbanissimo.Domain.Entities.Groups;

public class Group : BaseDomainEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    
    // Foreign keys
    public Guid CreatorId { get; set; }

    // Navigation
    public User Creator { get; set; }
    public List<GroupUser> Users { get; set; }
    public List<CanbanBoard> Boards { get; set; } 
}