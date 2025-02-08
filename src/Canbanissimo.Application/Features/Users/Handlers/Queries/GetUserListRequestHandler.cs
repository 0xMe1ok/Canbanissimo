using AutoMapper;
using Canbanissimo.Application.DTOs;
using Canbanissimo.Application.Features.Users.Requests;
using Canbanissimo.Application.Persistence.Contracts;
using MediatR;

namespace Canbanissimo.Application.Features.Users.Handlers.Queries;

public class GetUserListRequestHandler : IRequestHandler<GetUserListRequest, List<UserDto>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    
    public GetUserListRequestHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<List<UserDto>> Handle(GetUserListRequest request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAll();
        return _mapper.Map<List<UserDto>>(users);
    }
}