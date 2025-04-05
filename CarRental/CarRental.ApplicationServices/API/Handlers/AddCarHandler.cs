using AutoMapper;
using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;
using CarRental.DataAccess.CQRS;
using CarRental.DataAccess.CQRS.Commands;
using CarRental.DataAccess.Entities;
using MediatR;

namespace CarRental.ApplicationServices.API.Handlers
{
    public class AddCarHandler : IRequestHandler<AddCarRequest, AddCarResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public AddCarHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<AddCarResponse> Handle(AddCarRequest request, CancellationToken cancellationToken)
        {
            var car = this.mapper.Map<Car>(request);
            var command = new AddCarCommand() { Parameter = car };
            var carFromDb = await this.commandExecutor.Execute(command);
            return new AddCarResponse()
            {
                Data = this.mapper.Map<Domain.Models.Car>(carFromDb)
            };
        }
    }
}
