using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gigs
{
    /// <summary>
    /// Gigs data context
    /// </summary>
    public partial class GigsContext
    {
        /// <summary>
        /// Hydrate from repository. Recursively load about down to leaf objects.
        /// </summary>
        private void Initialize()
        {
            //   This is so much easier with autogen Entity Framework models.
            //   For this project, entities are hand generated

            //TODO: make this configurable for testing
            repository = new Repository.XMLGigsRepository();

            // load abouts
            var abouts = repository.GetAboutById(null);
            abouts.ToList().ForEach(about =>
            {
                AddAbout(about);
            });
        }

        /// <summary>
        /// Load about and it's children
        /// </summary>
        /// <param name="about"></param>
        private void AddAbout(Entities.About about)
        {
            abouts.Add(about);

            // load positions. Link objects and add to context collection
            var positions = repository.GetPositionByAboutId(about.AboutId);
            positions.ToList().ForEach(position =>
            {
                about.AddPosition(position);
                AddPosition(position);
                position.AboutId = about.AboutId;
            });

            // load trainings. Link objects and add to context collection
            var trainings = repository.GetTrainingByAboutId(about.AboutId);
            trainings.ToList().ForEach(training =>
            {
                about.AddTraining(training);
                AddTraining(training);
                training.AboutId = about.AboutId;
            });

            // load extras. Link objects and add to context collection
            var extras = repository.GetExtrasByAboutId(about.AboutId);
            extras.ToList().ForEach(extra =>
            {
                about.AddExtras(extra);
                AddExtra(extra);
                extra.AboutId = about.AboutId;
            });
        }

        /// <summary>
        /// Load position and it's children
        /// </summary>
        /// <param name="position"></param>
        private void AddPosition(Entities.Position position)
        {
            positions.Add(position);

            var notes = repository.GetNotesByPositionId(position.PositionId);
            notes.ToList().ForEach(note =>
            {
                position.AddNote(note);
                AddNote(note);
                note.PositionId = position.PositionId;
            });
        }

        /// <summary>
        /// Load Note and it's children
        /// </summary>
        /// <param name="note"></param>
        private void AddNote(Entities.Note note)
        {
            notes.Add(note);
        }

        /// <summary>
        /// Load Extra and it's children
        /// </summary>
        /// <param name="extra"></param>
        private void AddExtra(Entities.Extra extra)
        {
            extras.Add(extra);
        }

        /// <summary>
        /// Load Training and it's children
        /// </summary>
        /// <param name="training"></param>
        private void AddTraining(Entities.Training training)
        {
            trainings.Add(training);
        }
    }
}