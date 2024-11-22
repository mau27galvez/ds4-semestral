using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.comment;

[ApiController]
[Route("[controller]")]
public class CommentController(CommentService commentService) : ControllerBase
{
    [HttpGet("{groupId:guid}", Name = "GetIdolsByGroupId")]
    public async Task<IEnumerable<CommentResponse>> GetByGroupId(Guid groupId)
    {
        return await commentService.GetCommentsByGroupId(groupId);
    }
}
