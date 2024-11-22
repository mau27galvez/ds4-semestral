using Microsoft.EntityFrameworkCore;
using WebApplication1.shared.infrastructure;

namespace WebApplication1.group;

public class GroupService(AppDbContext appDbContext)
{
    public async Task<IEnumerable<GroupResponse>> GetGroups()
    {
        var groups = await appDbContext.Groups.ToListAsync();
        var groupsResponse = groups.Select(group => new GroupResponse(
            group.Id.ToString(),
            group.Name,
            group.Description,
            group.Photo
        )).ToList();

        return groupsResponse;
    }
}

public record GroupResponse(
    string Id,
    string Name,
    string Description,
    string Photo
);
