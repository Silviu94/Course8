using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course8.Models
{
    [Bind(Exclude = "Country")]
    public class ProjectEvaluationModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public double Rating { get; set; }


    }
}