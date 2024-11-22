using System.Globalization;
using Microsoft.EntityFrameworkCore;
using WebApplication1.shared.infrastructure;

namespace WebApplication1.comment;

public class CommentService(AppDbContext appDbContext)
{
    public async Task<IEnumerable<CommentResponse>> GetCommentsByGroupId(Guid groupId)
    {
        var comments = await appDbContext
            .Comments
            .Where(comment => comment.GroupId == groupId)
            .ToListAsync();

        var commentsResponse = comments
            .Select(comment => new CommentResponse(
                comment.Id.ToString(),
                comment.GroupId.ToString(),
                comment.AuthorId.ToString(),
                comment.Content,
                comment.CreatedAt.ToString(CultureInfo.InvariantCulture),
                comment.UpdatedAt?.ToString(CultureInfo.InvariantCulture)
            )).ToList();

        return commentsResponse;
    }
}

public record CommentResponse(
    string Id,
    string GroupId,
    string AuthorId,
    string Content,
    string CreatedAt,
    string? UpdatedAt
);

public record CommentRequest(
    Guid Id,
    Guid GroupId,
    Guid AuthorId,
    string Content,
    DateTime CreatedAt
);
