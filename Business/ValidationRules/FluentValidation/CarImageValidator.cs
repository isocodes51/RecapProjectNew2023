using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            //RuleFor(b => b.BrandName).Must(StartsWithA); //Buradaki "StartsWidthA" kendi yazacağımız Metodu temsil ediyor 
        }
    }
}
