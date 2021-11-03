using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.CustomAttributes
{
    public class StringRangeAttribute : ValidationAttribute
    {
        public string[] ValuesForParticipantStatus { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(ValuesForParticipantStatus?.Contains(value?.ToString()) == true)
            {
                return ValidationResult.Success;
            }

            var msg = $"Please enter one of the allowable values: {string.Join(", ", (ValuesForParticipantStatus ?? new string[] { "No allowable values was found" }))}.";
            return new ValidationResult(msg);
        }
    }
}
