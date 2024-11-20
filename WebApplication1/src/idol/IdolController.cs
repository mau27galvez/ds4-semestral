using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.idol;

[ApiController]
[Route("[controller]")]
public class IdolController(IdolService idolService) : ControllerBase
{
    private readonly IdolService _idolService = idolService;

    [HttpGet(Name = "GetIdols")]
    public async Task<IEnumerable<IdolResponse>> Get()
    {
        return await _idolService.GetIdols();
    }

    [HttpGet("{groupId:guid}", Name = "GetIdolsByGroupId")]
    public async Task<IEnumerable<IdolResponse>> GetByGroupId(Guid groupId)
    {
        return await _idolService.GetIdolsByGroupId(groupId);
    }
}
