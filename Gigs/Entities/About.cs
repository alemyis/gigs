using System;
using System.Collections.Generic;
using System.Data.Services.Common;
using System.Linq;
using System.Web;

namespace Gigs.Entities
{
    [DataServiceKey("AboutId")]
    public class About
    {
        public int AboutId { get; set; }

        /// <summary>
        /// Add a positions held
        /// </summary>
        /// <param name="position">The position to add</param>
        public void AddPosition(Position position)
        {
            positions.Add(position);
        }

        /// <summary>
        /// Add a trainings taken
        /// </summary>
        /// <param name="training">The training to add</param>
        public void AddTraining(Training training)
        {
            trainings.Add(training);
        }

        /// <summary>
        /// Add extra note
        /// </summary>
        /// <param name="extra">The extra note to add</param>
        public void AddExtras(Extra extra)
        {
            extras.Add(extra);
        }

        private ICollection<Position> positions = new List<Position>();
        public IQueryable<Position> Positions
        {
            get
            {
                return positions.AsQueryable();
            }
        }

        private ICollection<Training> trainings = new List<Training>();
        public IQueryable<Training> Trainings
        {
            get
            {
                return trainings.AsQueryable();
            }
        }

        private ICollection<Extra> extras = new List<Extra>();
        public IQueryable<Extra> Extras
        {
            get
            {
                return extras.AsQueryable();
            }
        } 
    }
}