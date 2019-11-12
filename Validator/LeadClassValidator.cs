using FluentValidation;
using IntegrateTechnicalTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrateTechnicalTest.Validator
{
    public class LeadClassValidator : AbstractValidator<LeadClass>
    {
        public LeadClassValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name required");
            RuleFor(x => x.FirstName).Length(1,15).WithMessage("First Name mmust be between 1 to 15 character length");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name Required");
            RuleFor(x => x.LastName).Length(1, 15).WithMessage("Last Name mmust be between 1 to 15 character length");

        }
    }
}    

