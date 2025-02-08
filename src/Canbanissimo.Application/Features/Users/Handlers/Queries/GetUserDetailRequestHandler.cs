using AutoMapper;
using Canbanissimo.Application.DTOs;
using Canbanissimo.Application.Features.Users.Requests;
using Canbanissimo.Application.Persistence.Contracts;
using MediatR;

namespace Canbanissimo.Application.Features.Users.Handlers.Queries;

public class GetUserDetailRequestHandler : IRequestHandler<GetUserDetailRequest, UserDto>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    
    public GetUserDetailRequestHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<UserDto> Handle(GetUserDetailRequest request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.Get(request.Id);
        return _mapper.Map<UserDto>(user);
    }
}