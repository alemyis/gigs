using System;
using System.Collections.Generic;
using System.Data.Services.Common;
using System.Linq;
using System.Web;

namespace Gigs.Entities
{
    [DataServiceKey("ExtraId")]
    public class Extra
    {
        public int ExtraId { get; set; }
    }
}