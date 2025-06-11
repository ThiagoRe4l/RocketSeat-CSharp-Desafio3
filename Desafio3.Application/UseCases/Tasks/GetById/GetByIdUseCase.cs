using Desafio3.Communication.Responses;

namespace Desafio3.Application.UseCases.Tasks.GetById;

public class GetByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Title = "limpar casa",
            Description = "preciso limpar a casa",
            Status = Communication.Enums.TaskStatus.Pending,
            DueDate = "2025-12-31",
            Priority = Communication.Enums.TaskPriority.High
        };
    }
}
