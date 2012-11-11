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
    }
}