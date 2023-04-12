using AutoMapper;
using FluentValidation;
using LeaveManagement_Backend.Application.Contracts.Infrastructure;
using LeaveManagement_Backend.Application.Contracts.Persistence.Interfaces;
using LeaveManagement_Backend.Application.DTOs.LeaveRequest.Validators;
using LeaveManagement_Backend.Application.Features.LeaveRequests.Requests.Commands;
using LeaveManagement_Backend.Application.Features.LeaveTypes.Requests.Commands;
using LeaveManagement_Backend.Application.Models;
using LeaveManagement_Backend.Application.Response;
using LeaveManagement_Backend.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler <CreateLeaveRequestCommand, BaseCommandResponse>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;
       

        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, ILeaveTypeRepository leaveTypeRepository, IEmailSender emailSender, IMapper mapper)
         {
            _leaveTypeRepository = leaveTypeRepository;
            _leaveRequestRepository = leaveRequestRepository;
            _emailSender = emailSender;
            _mapper = mapper;
        }

      

        public async Task<BaseCommandResponse> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateLeaveRequestDtoValidator(_leaveTypeRepository);
            var validationResult = await validator.ValidateAsync(request.LeaveRequestDto);

             if (validationResult.IsValid == false)
             {
                 response.Success = false;
                 response.Message = "Creation Failed";
                 response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
             }

             var leaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);
             leaveRequest = await _leaveRequestRepository.Add(leaveRequest);
             response.Success = true;
             response.Message= "Creation successful";
             response.Id = leaveRequest.Id;
            var email = new Email
            {
                To = "khawla.benmansour6@gmail.com",
                Body = $"Your leave request for {request.LeaveRequestDto.StartDate:D} to {request.LeaveRequestDto.EndDate:D} " +
                       $"has been submitted successfully.",
                Subject = "Leave Request Submitted"
            };
            try
            {
                await _emailSender.SenderEmail(email);
            }
            catch (Exception ex)
            {

            }


            return response;



        }
    }
   
}
