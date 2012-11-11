using System;
using System.Collections.Generic;
using System.Data.Services.Common;
using System.Linq;
using System.Web;

namespace Gigs.Entities
{
    [DataServiceKey("PositionId")]
    public class Position
    {
        public int PositionId { get; set; }

        /// <summary>
        /// Add a note
        /// </summary>
        /// <param name="note">The note to add</param>
        public void AddNote(Note note)
        {

        }

        private ICollection<Note> notes = new List<Note>();
        public IQueryable<Note> Notes
        {
            get
            {
                return notes.AsQueryable();
            }
        }
    }
}