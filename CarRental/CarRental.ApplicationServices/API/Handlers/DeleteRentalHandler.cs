using AutoMapper;
using CarRental.ApplicationServices.API.Domain.RentalReqAndResp;
using CarRental.DataAccess.CQRS.Commands;
using CarRental.DataAccess.CQRS;
using MediatR;

namespace CarRental.ApplicationServices.API.Handlers
{
    public class DeleteRentalHandler : IRequestHandler<DeleteRentalRequest, DeleteRentalResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public DeleteRentalHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper; 
            this.commandExecutor = commandExecutor;
        }

        public async Task<DeleteRentalResponse> Handle(DeleteRentalRequest request, CancellationToken cancellationToken)
        {
            var command = new DeleteRentalCommand() { Id = request.Id };

            var deletedRental = await this.commandExecutor.Execute(command);

            if (deletedRental == null)
            {
                return new DeleteRentalResponse() { Data = null };
            }

            return new DeleteRentalResponse()
            {
                Data = this.mapper.Map<Domain.Models.Rental>(deletedRental)
            };
        }
    }
}
