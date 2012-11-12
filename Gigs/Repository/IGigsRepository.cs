using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gigs.Repository
{
    public interface IGigsRepository
    {
        ICollection<Entities.About> GetAboutById(int? aboutId);
        ICollection<Entities.Training> GetTrainingByAboutId(int? aboutId);
        ICollection<Entities.Extra> GetExtrasByAboutId(int? aboutId);
        ICollection<Entities.Position> GetPositionByAboutId(int? aboutId);
        ICollection<Entities.Note> GetNotesByPositionId(int? positionId);
    }
}
