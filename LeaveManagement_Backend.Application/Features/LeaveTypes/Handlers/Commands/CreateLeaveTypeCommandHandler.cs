using AutoMapper;
using FluentValidation;
using LeaveManagement_Backend.Application.Contracts.Persistence.Interfaces;
using LeaveManagement_Backend.Application.DTOs.LeaveType.Validators;
using LeaveManagement_Backend.Application.Features.LeaveTypes.Requests.Commands;
using LeaveManagement_Backend.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveTypeCommand request , CancellationToken cancellationToken)
        {
           // var validator = new CreateLeaveTypeDtoValidator();
            //var validationResult = await validator.ValidateAsync(request.LeaveTypeDto);
           // var validationResult = await validator.ValidateAsync(request.LeaveTypeDto);
            //if (validationResult.IsValid == false)
               // throw new FluentValidation.ValidationException((IEnumerable<FluentValidation.Results.ValidationFailure>)validationResult);

            var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);
            leaveType = await _leaveTypeRepository.Add(leaveType);
            return leaveType.Id;


        }
    }
}
