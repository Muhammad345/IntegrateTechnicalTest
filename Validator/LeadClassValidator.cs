using FluentValidation;
using IntegrateTechnicalTest.Common;
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
            RuleFor(x => x.FirstName).MaximumLength(DataLength.FirstName).WithMessage("First Name mmust be between 1 to 15 character length");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name Required");
            RuleFor(x => x.LastName).MaximumLength(DataLength.LastName).WithMessage("Last Name mmust be between 1 to 15 character length");
            RuleFor(x => x.Email).MaximumLength(DataLength.EmailAddress).WithMessage("Email address should not greater then 25 character");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please enter Valid email address");
            RuleFor(x => x.IsAcceptedTerms).Equal(true).WithMessage("Please accept our Terms and conditions");
        }
    }
}    

