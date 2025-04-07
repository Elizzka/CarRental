using AutoMapper;
using CarRental.ApplicationServices.API.Domain.CustomerReqAndResp;
using CarRental.DataAccess.CQRS.Commands;
using CarRental.DataAccess.CQRS;
using MediatR;
using CarRental.DataAccess.Entities;

namespace CarRental.ApplicationServices.API.Handlers
{
    public class AddCustomerHandler : IRequestHandler<AddCustomerRequest, AddCustomerResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public AddCustomerHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<AddCustomerResponse> Handle(AddCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = this.mapper.Map<Customer>(request);
            var command = new AddCustomerCommand() { Parameter = customer };
            var customerFromDb = await this.commandExecutor.Execute(command);
            return new AddCustomerResponse()
            {
                Data = this.mapper.Map<Domain.Models.Customer>(customerFromDb)
            };
        }
    }
}
