using Canbanissimo.Domain.Common;

namespace Canbanissimo.Domain.Entities.Canban;

public class CanbanColumn : BaseDomainEntity
{
    public string Title { get; set; }
    public int Order { get; set; }
    public Guid BoardId { get; set; }
    
    // Navigation
    public CanbanBoard CanbanBoard { get; }
    public List<CanbanTask> Tasks { get; set; }
}