using FluentValidation;
using LeaveManagement_Backend.Application.Contracts.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.DTOs.LeaveRequest.Validators
{
    public class ILeaveRequestDtoValidator : AbstractValidator<ILeaveRequestDto>
    {
        private ILeaveTypeRepository _leaveTypeRepository;
        public ILeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            RuleFor(p => p.StartDate)
              .LessThan(DateTime.Now).WithMessage("{ProprietyName} must be before {Comparisonvalue}");

            RuleFor(p => p.EndDate)

                .GreaterThan(p => p.StartDate).WithMessage("{ProprietyName} must be before {Comparisonvalue}");

            RuleFor(p => p.LeaveTypeId)
                   .GreaterThan(0)
                   .MustAsync(async (id, token) =>
                   {
                       var leaveTypeExists = await _leaveTypeRepository.Exists(id);
                       return !leaveTypeExists;
                   })
                   .WithMessage("{PropertyName} does not exist");

        }
    }
}
