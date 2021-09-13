using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW6.Entities
{
    public class Song
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual double Duration { get; set; }
        public virtual DateTime ReleasedDate { get; set; }
        public virtual int GanreId { get; set; }
        public virtual Ganre Ganre { get; set; }
        public virtual List<ArtistsSongs> Artists { get; set; } = new List<ArtistsSongs>();
    }
}
