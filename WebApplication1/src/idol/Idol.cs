namespace WebApplication1.idol;

public record Idol(
    Guid Id,
    Guid GroupId,
    string Name,
    string RealName,
    string Photo
);
