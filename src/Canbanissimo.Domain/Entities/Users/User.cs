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
    public List<GroupUser> GroupUsers { get; set; } 
    public List<Group> Groups { get; set; }
    public List<Task> AssignedTasks { get; set; } 
}