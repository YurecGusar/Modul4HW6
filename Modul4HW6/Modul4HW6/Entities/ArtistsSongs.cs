using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW6.Entities
{
    public class ArtistsSongs
    {
        public virtual int Id { get; set; }
        public virtual int SongsId { get; set; }
        public virtual Song Song { get; set; }
        public virtual int ArtistsId { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
