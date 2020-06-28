using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SurveyModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public string City { get; set; }
        public string FileName { get; set; }
        public string[] Education { get; set; }
    }
}