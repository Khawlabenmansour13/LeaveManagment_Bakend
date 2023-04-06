using FluentValidation;
using LeaveManagement_Backend.Application.Contracts.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.DTOs.LeaveAllocation.Validators
{
    public class CreateLeaveAllocationDtoValidator : AbstractValidator<CreateLeaveAllocationDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveAllocationDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = _leaveTypeRepository;

            /*  RuleFor(p => p.LeaveTypeId)
                  .GreaterThan(0)
                  .MustAsync(async (id, token) =>
                  {
                      var leaveTypeExists = await _leaveTypeRepository.Exists(id);
                      return leaveTypeExists;
                  })
                  .WithMessage("{PropertyName} does not exist.");*/
            Include(new ILeaveAllocationDtoValidator(_leaveTypeRepository));
        }
    }
}
