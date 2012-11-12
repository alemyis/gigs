using System;
using System.Collections.Generic;
using System.Data.Services.Common;
using System.Linq;
using System.Web;

namespace Gigs.Entities
{
    [DataServiceKey("TrainingId")]
    public class Training
    {
        public int TrainingId { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Institution { get; set; }

        public DateTime GraduationDate { get; set; }

        public string Degree { get; set; }

        public int AboutId { get; set; }
    }
}