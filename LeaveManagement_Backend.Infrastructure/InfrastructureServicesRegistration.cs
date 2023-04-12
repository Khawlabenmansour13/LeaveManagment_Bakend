using LeaveManagement_Backend.Application.Contracts.Infrastructure;
using LeaveManagement_Backend.Application.Contracts.Persistence.Interfaces;
using LeaveManagement_Backend.Application.Models;
using LeaveManagement_Backend.Infrastructure.Mail;
using LeaveManagement_Backend.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Infrastructure
{
    public static  class InfrastructureServicesRegistration
    {
        
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));


            services.AddTransient<IEmailSender, EmailSender>();

            return services;
        }
    }
}

