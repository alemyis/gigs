using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Gigs.Repository
{
    public class XMLGigsRepository : IGigsRepository
    {
        private DataSource dataSource;
        public XMLGigsRepository()
        {
            var xsr = new XmlSerializer(typeof(DataSource));
            using(var fileStream = new FileStream(HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["GigsXmlData"]), FileMode.Open))
            {
                dataSource = xsr.Deserialize(fileStream) as DataSource;
            }
        }

        public ICollection<Entities.About> GetAboutById(int? aboutId)
        {
            return dataSource.Abouts.Where(a => !aboutId.HasValue || a.AboutId == aboutId.Value).ToList();
        }

        public ICollection<Entities.Training> GetTrainingByAboutId(int? aboutId)
        {
            return dataSource.Trainings.Where(a => !aboutId.HasValue || a.AboutId == aboutId.Value).ToList();
        }

        public ICollection<Entities.Extra> GetExtrasByAboutId(int? aboutId)
        {
            return dataSource.Extras.Where(a => !aboutId.HasValue || a.AboutId == aboutId.Value).ToList();
        }

        public ICollection<Entities.Position> GetPositionByAboutId(int? aboutId)
        {
            return dataSource.Positions.Where(a => !aboutId.HasValue || a.AboutId == aboutId.Value).ToList();
        }

        public ICollection<Entities.Note> GetNotesByPositionId(int? positionId)
        {
            return dataSource.Notes.Where(a => !positionId.HasValue || a.PositionId == positionId.Value).ToList();
        }
    }
    
    
    public class DataSource
    {
        public List<Entities.About> Abouts { get; set; }
        public List<Entities.Position> Positions { get; set; }
        public List<Entities.Note> Notes { get; set; }
        public List<Entities.Training> Trainings { get; set; }
        public List<Entities.Extra> Extras { get; set; }
    }
}