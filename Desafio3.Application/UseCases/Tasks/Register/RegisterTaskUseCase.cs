using Desafio3.Communication.Requests;
using Desafio3.Communication.Responses;

namespace Desafio3.Application.UseCases.Tasks.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
    {  
        return new ResponseRegisteredTaskJson
        {
            Id = 1,
            Title = request.Title,
            Status = request.Status,
            CreatedAt = DateTime.UtcNow
        };
    }
}
