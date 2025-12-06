namespace SecureAPI.Controllers.DTOS
{
    public record DemoRequest(string Input);

    public record UpdateDto(string Name);

    public record LoginRequest(string Username, string Password);
}
