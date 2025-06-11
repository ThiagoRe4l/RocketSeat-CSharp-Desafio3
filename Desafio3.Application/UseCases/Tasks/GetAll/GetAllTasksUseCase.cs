using Desafio3.Communication.Responses;
using TaskStatus = Desafio3.Communication.Enums.TaskStatus;

namespace Desafio3.Application.UseCases.Tasks.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Task = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Title = "Task 1",
                    Status = TaskStatus.Pending
                },
                new ResponseShortTaskJson
                {
                    Id = 2,
                    Title = "Task 2",
                    Status = TaskStatus.Completed
                }
            }
        };
    }
}
