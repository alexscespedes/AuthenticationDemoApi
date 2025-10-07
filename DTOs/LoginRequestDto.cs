namespace AuthDemoApi.DTOs;

public record class LoginRequestDto
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}
