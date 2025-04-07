using AutoMapper;
using CarRental.ApplicationServices.API.Domain.RentalReqAndResp;
using CarRental.DataAccess.CQRS.Commands;
using CarRental.DataAccess.CQRS;
using MediatR;
using CarRental.DataAccess.Entities;

namespace CarRental.ApplicationServices.API.Handlers
{
    public class AddRentalHandler : IRequestHandler<AddRentalRequest, AddRentalResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public AddRentalHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<AddRentalResponse> Handle(AddRentalRequest request, CancellationToken cancellationToken)
        {
            var rental = this.mapper.Map<Rental>(request);
            var command = new AddRentalCommand() { Parameter = rental };
            var rentalFromDb = await this.commandExecutor.Execute(command);
            return new AddRentalResponse()
            {
                Data = this.mapper.Map<Domain.Models.Rental>(rentalFromDb)
            };
        }
    }
}
