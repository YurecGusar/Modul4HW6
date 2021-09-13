using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW6.Entities
{
    public class Genre
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual List<Song> Songs { get; set; } = new List<Song>();
    }
}
