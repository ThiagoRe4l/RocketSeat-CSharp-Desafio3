namespace Desafio3.Communication.Responses;
using TaskStatus = Enums.TaskStatus;

public class ResponseShortTaskJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public TaskStatus Status { get; set; } = TaskStatus.Pending;
}
