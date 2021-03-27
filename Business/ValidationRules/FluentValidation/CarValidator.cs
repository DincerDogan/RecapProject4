using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
   public  class CarValidator:AbstractValidator<Car>
   {
       public CarValidator()
       {
           RuleFor(p => p.DailyPrice).GreaterThan(0);
           RuleFor(p => p.Description).MaximumLength(10);
           RuleFor(p => p.ModelYear).GreaterThan(1900);
           RuleFor(p => p.Description).Must(StartWithA);

       }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
