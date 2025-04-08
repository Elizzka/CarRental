using AutoMapper;
using CarRental.ApplicationServices.API.Domain;
using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;
using CarRental.ApplicationServices.API.ErrorHandling;
using CarRental.DataAccess.CQRS;
using CarRental.DataAccess.CQRS.Queries;
using MediatR;

namespace CarRental.ApplicationServices.API.Handlers
{
    public class GetCarsHandler : IRequestHandler<GetCarsRequest, GetCarsResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetCarsHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetCarsResponse> Handle(GetCarsRequest request, CancellationToken cancellationToken)
        {
            var query = new GetCarsQuery()
            {
                Brand = request.Brand
            };

            var cars = await this.queryExecutor.Execute(query);

            if (cars == null)
            {
                return new GetCarsResponse()
                {
                    Error = new ErrorModel(ErrorType.NotFound)
                };
            }
            
            var mappedCar = this.mapper.Map<List<Domain.Models.Car>>(cars);
            var response = new GetCarsResponse()
            {
                Data = mappedCar
            };
            return response;
        }
    }
}
