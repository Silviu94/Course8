using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Course8.CustomAttributes
{
    public class MaxWordsAttributes:ValidationAttribute 

    {
        private readonly int _maxwords;

            public MaxWordsAttributes(int maxWords):base("{0} has too many words.")
            {
            _maxwords = maxWords;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value!=null)
            {
                var valueAsString = value.ToString();
                if (valueAsString.Split(' ').Length > _maxwords)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
                     
                }
                return ValidationResult.Success;
            }
        }
    }
