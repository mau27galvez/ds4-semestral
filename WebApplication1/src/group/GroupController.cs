using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.group;

[ApiController]
[Route("[controller]")]
public class GroupController(GroupService groupService) : ControllerBase
{
    [HttpGet(Name = "GetGroups")]
    public async Task<IEnumerable<GroupResponse>> Get()
    {
        return await groupService.GetGroups();
    }
}
