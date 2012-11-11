using System;
using System.Collections.Generic;
using System.Data.Services.Common;
using System.Linq;
using System.Web;

namespace Gigs.Entities
{
    [DataServiceKey("NoteId")]
    public class Note
    {
        public int NoteId { get; set; }
    }
}