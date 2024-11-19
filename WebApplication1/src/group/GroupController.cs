using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.group;

[ApiController]
[Route("[controller]")]
public class GroupController(GroupService groupService) : ControllerBase
{
    private readonly GroupService _groupService = groupService;

    [HttpGet(Name = "GetGroups")]
    public async Task<IEnumerable<GroupResponse>> Get()
    {
        return await _groupService.GetGroups();
    }
}
