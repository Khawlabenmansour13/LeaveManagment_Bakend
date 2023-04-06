using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Exceptions
{
    public  class ValidatorException :ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();
        public ValidatorException( ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors )
            {
                Errors.Add( error.ErrorMessage );   
            }
            
        }
    }
}
