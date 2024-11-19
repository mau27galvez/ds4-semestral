using Microsoft.EntityFrameworkCore;
using WebApplication1.shared.infrastructure;

namespace WebApplication1.group;

public class GroupService(AppDbContext appDbContext)
{
    private readonly AppDbContext _appDbContext = appDbContext;

    public async Task<IEnumerable<GroupResponse>> GetGroups()
    {
        var groups = await _appDbContext.Groups.ToListAsync();
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
