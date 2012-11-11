using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gigs
{
    /// <summary>
    /// Gigs data context
    /// </summary>
    public class GigsContext
    {
        private GigsContext()
        {
            //TODO: initialization
        }

        /// <summary>
        /// Singleton Gigs context
        /// </summary>
        private static readonly GigsContext instance = new GigsContext();
        public static GigsContext Intance
        {
            get { return instance; }
        }

        private ICollection<Entities.About> abouts = new List<Entities.About>();
        public IQueryable<Entities.About> Abouts
        {
            get
            {
                return abouts.AsQueryable();
            }
        }

        private ICollection<Entities.Position> positions = new List<Entities.Position>();
        public IQueryable<Entities.Position> Positions
        {
            get
            {
                return positions.AsQueryable();
            }
        }

        private ICollection<Entities.Training> trainings = new List<Entities.Training>();
        public IQueryable<Entities.Training> Trainings 
        {
            get
            {
                return trainings.AsQueryable();
            }
        }

        private ICollection<Entities.Note> notes = new List<Entities.Note>();
        public IQueryable<Entities.Note> Notes
        {
            get
            {
                return notes.AsQueryable();
            }
        }

        private ICollection<Entities.Extra> extras = new List<Entities.Extra>();
        public IQueryable<Entities.Extra> Extras 
        {
            get
            {
                return extras.AsQueryable();
            }
        }

    }
}