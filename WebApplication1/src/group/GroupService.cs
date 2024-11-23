using Microsoft.EntityFrameworkCore;
using WebApplication1.idol;
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

    public async Task<GroupResponse> GetGroupById(Guid groupId)
    {
        var group = await appDbContext.Groups.Where(group => group.Id == groupId).FirstAsync();
        var groupResponse = new GroupResponse(
            group.Id.ToString(),
            group.Name,
            group.Description,
            group.Photo
        );

        return groupResponse;
    }

    public async Task<IEnumerable<IdolResponse>> GetIdolsByGroupId(Guid groupId)
    {
        var idols = await appDbContext.Idols.Where(idol => idol.GroupId == groupId).ToListAsync();
        var idolsResponse = idols.Select(idol => new IdolResponse(
            idol.Id.ToString(),
            idol.GroupId.ToString(),
            idol.Name,
            idol.RealName,
            idol.About,
            idol.Photo
        )).ToList();

        return idolsResponse;
    }
}

public record GroupResponse(
    string Id,
    string Name,
    string About,
    string Photo
);
