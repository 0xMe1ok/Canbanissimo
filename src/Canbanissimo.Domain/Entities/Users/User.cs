using Canbanissimo.Domain.Common;
using Canbanissimo.Domain.Entities.Groups;

namespace Canbanissimo.Domain.Entities.Users;
public class User : BaseDomainEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; }

    // Navigation
    public List<Group> GroupsIn { get; set; }
    public List<Task> AssignedTasks { get; set; } 
}