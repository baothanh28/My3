﻿using My.Domain.Entities;
using My.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace My.Application.Roles.Commands
{
    public class AddClaimCommand : ICommand
    {
        public Role Role { get; set; }
        public RoleClaim Claim { get; set; }
    }

    internal class AddClaimCommandHandler : ICommandHandler<AddClaimCommand>
    {
        private readonly IRoleRepository _roleRepository;

        public AddClaimCommandHandler(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task HandleAsync(AddClaimCommand command, CancellationToken cancellationToken = default)
        {
            command.Role.Claims.Add(command.Claim);
            await _roleRepository.UnitOfWork.SaveChangesAsync();
        }
    }
}
