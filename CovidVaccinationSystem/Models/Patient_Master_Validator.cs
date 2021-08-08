using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccinationSystem.Models
{
    public class Patient_Master_Validator:AbstractValidator<Patient_Master>
    {
        public Patient_Master_Validator()
        {
            RuleFor(x => x.Pat_Name).NotEmpty().WithMessage("Patient Name Required").MaximumLength(500).WithMessage("Maximum 500 character");
            RuleFor(x => x.Pat_Email).EmailAddress().WithMessage("Invalid Email Id");
            RuleFor(x => x.Pat_Age).NotNull().GreaterThan(3).WithMessage("Age above 3 are eligiable to get vaccine");
        }
    }
}
