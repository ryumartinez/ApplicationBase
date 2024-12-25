namespace Accessors.Dtos;

public record UpdateUserAccessRequest(
    int Id,
    string Name,
    string Email
    );