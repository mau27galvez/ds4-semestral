using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.idol;

[ApiController]
[Route("[controller]")]
public class IdolController(IdolService idolService) : ControllerBase
{
    [HttpGet(Name = "GetIdols")]
    public async Task<IEnumerable<IdolResponse>> Get()
    {
        return await idolService.GetIdols();
    }

    [HttpGet("{groupId:guid}", Name = "GetCommentsByGroupId")]
    public async Task<IEnumerable<IdolResponse>> GetByGroupId(Guid groupId)
    {
        return await idolService.GetIdolsByGroupId(groupId);
    }
}
