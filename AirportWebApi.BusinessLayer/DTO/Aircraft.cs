using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Aircraft : BaseObject
    {
        public string Name { get; set; }

        public int AirType { get; set; }

        public string ReleaseDate { get; set; }
        public string LifeTime { get; set; }
    }

    public class AircraftValidator : AbstractValidator<Aircraft>
    {
        public AircraftValidator()
        {
            RuleFor(air => air.Name)
                .NotEmpty();
        }
    }
}
