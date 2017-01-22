using Course8.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course8.Models
{
    [Bind(Exclude = "Country")]
    public class ProjectEvaluationModels:IValidatableObject
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Name { get; set; }
        [MaxWordsAttributes(2)]
        public string City { get; set; }
        public string Country { get; set; }
        [Required,Range(1,10)]        
        public double Rating { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Rating<2 && Name.ToLower().StartsWith("john"))
            { yield return new ValidationResult("Sorry John ,you can't do this"); }
        }
    }
}