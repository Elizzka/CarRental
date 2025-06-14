﻿using AutoMapper;
using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;
using CarRental.DataAccess.CQRS.Commands;
using CarRental.DataAccess.CQRS;
using MediatR;

namespace CarRental.ApplicationServices.API.Handlers
{
    public class DeleteCarHandler : IRequestHandler<DeleteCarRequest, DeleteCarResponse>
    {

        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public DeleteCarHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<DeleteCarResponse> Handle(DeleteCarRequest request, CancellationToken cancellationToken)
        {
            var command = new DeleteCarCommand() { Id = request.Id };

            var deletedCar = await this.commandExecutor.Execute(command);

            if (deletedCar == null)
            {
                return new DeleteCarResponse() { Data = null }; 
            }

            return new DeleteCarResponse()
            {
                Data = this.mapper.Map<Domain.Models.Car>(deletedCar)
            };
        }
    }
}
