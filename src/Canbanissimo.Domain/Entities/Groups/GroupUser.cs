using Canbanissimo.Domain.Common;
using Canbanissimo.Domain.Entities.Users;
using Canbanissimo.Domain.Enum;

namespace Canbanissimo.Domain.Entities.Groups;

public class GroupUser : BaseDomainEntity
{
    // Foreign keys
    public Guid GroupId { get; set; }
    public Guid UserId { get; set; }
    
    // Navigation
    public Group Group { get; set; }
    public User User { get; set; }
    
    public GroupRole Role { get; set; }
}