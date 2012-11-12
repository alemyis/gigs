using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gigs.Repository
{
    /// <summary>
    /// Hard coded return values
    /// </summary>
    public class AlemeshetAlemu : IGigsRepository
    {
        public ICollection<Entities.About> GetAboutById(int? aboutId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Entities.Training> GetTrainingByAboutId(int? aboutId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Entities.Extra> GetExtrasByAboutId(int? aboutId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Entities.Position> GetPositionByAboutId(int? aboutId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Entities.Note> GetNotesByPositionId(int? positionId)
        {
            throw new NotImplementedException();
        }
    }
}