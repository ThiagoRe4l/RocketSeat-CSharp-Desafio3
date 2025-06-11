using TaskStatus = Desafio3.Communication.Enums.TaskStatus;

namespace Desafio3.Communication.Responses;

public class ResponseRegisteredTaskJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public TaskStatus Status { get; set; } = TaskStatus.Pending;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
