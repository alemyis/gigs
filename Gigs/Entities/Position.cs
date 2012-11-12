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
            notes.Add(note);
        }

        private ICollection<Note> notes = new List<Note>();
        public IQueryable<Note> Notes
        {
            get
            {
                return notes.AsQueryable();
            }
        }

        public string Title { get; set; }

        public string Employer { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public int AboutId { get; set; }
    }
}