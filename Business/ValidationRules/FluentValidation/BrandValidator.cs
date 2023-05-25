using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).MinimumLength(2);
            //RuleFor(b => b.BrandName).Must(StartsWithA); //Buradaki "StartsWidthA" kendi yazacağımız Metodu temsil ediyor 
        }
    }
}
