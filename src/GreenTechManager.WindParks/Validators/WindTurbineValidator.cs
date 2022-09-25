﻿using FluentValidation;
using GreenTechManager.WindParks.Constants;
using GreenTechManager.WindParks.Models;

namespace GreenTechManager.WindParks.Validators
{
    public class WindTurbineValidator : AbstractValidator<WindTurbineModel>
    {
        public WindTurbineValidator()
        {
            RuleFor(x => x.Type)
                .NotEmpty()
                .MaximumLength(ValidationConstants.DefaultMaxLength);

            RuleFor(x => x.Location)
                .NotEmpty()
                .MaximumLength(ValidationConstants.DefaultMaxLength);

            RuleFor(x => x.PowerOutput).GreaterThan(0);

            RuleFor(x => x.RotorDiameter).GreaterThan(0);

            RuleFor(x => x.HubHeight).GreaterThan(0);

            RuleFor(x => x.WindParkId).GreaterThan(0);
        }
    }
}
