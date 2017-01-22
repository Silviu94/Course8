using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course8.Models
{
    [Bind(Exclude = "Country")]
    public class ProjectEvaluationModels
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        [Required,Range(1,10)]        
        public double Rating { get; set; }


    }
}