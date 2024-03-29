﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(p => p.CarId).NotEmpty();
            RuleFor(p => p.Date_).NotEmpty();
            RuleFor(p => p.CarImageId).NotEmpty();
            RuleFor(p => p.ImagePath).NotEmpty();
        }
    }
}
