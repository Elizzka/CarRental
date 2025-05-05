//using AutoMapper;
//using CarRental.DataAccess.CQRS.Commands;
//using CarRental.DataAccess.CQRS;
//using MediatR;
//using CarRental.ApplicationServices.API.Domain.UserReqAndResp;
//using CarRental.DataAccess.Entities;
//using CarRental.Authentication;

//namespace CarRental.ApplicationServices.API.Handlers
//{
//    public class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
//    {
//        private readonly IMapper mapper;
//        private readonly ICommandExecutor commandExecutor;

//        public CreateUserHandler(IMapper mapper, ICommandExecutor commandExecutor)
//        {
//            this.mapper = mapper;
//            this.commandExecutor = commandExecutor;
//        }

//        public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
//        {
//            string salt;
//            string hashedPassword = PasswordHasher.HashPassword(request.Password, out salt);

//            var user = this.mapper.Map<CarRental.DataAccess.Entities.User>(request);

//            user.Password = hashedPassword;
//            user.Salt = salt;

//            var command = new CreateUserCommand() { Parameter = user };
//            var userFromDb = await this.commandExecutor.Execute(command);

//            return new CreateUserResponse()
//            {
//                Data = this.mapper.Map<Domain.Models.User>(userFromDb)
//            };
//        }
//    }
//}
