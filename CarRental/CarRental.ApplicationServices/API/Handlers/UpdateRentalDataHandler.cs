using AutoMapper;
using CarRental.DataAccess.CQRS.Commands;
using CarRental.DataAccess.CQRS;
using MediatR;
using CarRental.ApplicationServices.API.Domain.RentalDataReqAndResp;
using CarRental.DataAccess.Entities;

namespace CarRental.ApplicationServices.API.Handlers
{
    public class UpdateRentalDataHandler : IRequestHandler<UpdateRentalDataRequest, UpdateRentalDataResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public UpdateRentalDataHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<UpdateRentalDataResponse> Handle(UpdateRentalDataRequest request, CancellationToken cancellationToken)
        {
            var rentalData = this.mapper.Map<RentalData>(request);
            var command = new UpdateRentalDataCommand() { Parameter = rentalData };
            var updatedRentalData = await this.commandExecutor.Execute(command);
            return new UpdateRentalDataResponse()
            {
                Data = this.mapper.Map<Domain.Models.RentalData>(updatedRentalData)
            };
        }
    }
}
