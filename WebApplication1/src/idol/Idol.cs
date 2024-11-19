namespace WebApplication1.idol.domain;

public record Idol
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string RealName { get; init; }
    public string Photo { get; init; }
}
