using Microsoft.EntityFrameworkCore;
using WebApplication1.shared.infrastructure;

namespace WebApplication1.idol;

public class IdolService(AppDbContext appDbContext)
{
    private readonly AppDbContext _appDbContext = appDbContext;

    public async Task<IEnumerable<IdolResponse>> GetIdols()
    {
        var idols = await _appDbContext.Idols.ToListAsync();
        var idolsResponse = idols.Select(idol => new IdolResponse(
            idol.Id.ToString(),
            idol.GroupId.ToString(),
            idol.Name,
            idol.RealName,
            idol.Photo
        )).ToList();

        return idolsResponse;
    }
}

public record IdolResponse(
    string Id,
    string GroupId,
    string Name,
    string RealName,
    string Photo
);
