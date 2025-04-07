using AutoMapper;
using CarRental.ApplicationServices.API.Domain.RentalReqAndResp;
using CarRental.DataAccess.CQRS.Commands;
using CarRental.DataAccess.CQRS;
using MediatR;
using CarRental.DataAccess.Entities;

namespace CarRental.ApplicationServices.API.Handlers
{
    public class UpdateRentalHandler : IRequestHandler<UpdateRentalRequest, UpdateRentalResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public UpdateRentalHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<UpdateRentalResponse> Handle(UpdateRentalRequest request, CancellationToken cancellationToken)
        {
            var rental = this.mapper.Map<Rental>(request);
            var command = new UpdateRentalCommand() { Parameter = rental };
            var updatedRental = await this.commandExecutor.Execute(command);
            return new UpdateRentalResponse()
            {
                Data = this.mapper.Map<Domain.Models.Rental>(updatedRental)
            };
        }
    }
}
