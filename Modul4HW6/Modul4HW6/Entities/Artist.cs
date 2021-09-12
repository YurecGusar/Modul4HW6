using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW6.Entities
{
    public class Artist
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual string InstagramUrl { get; set; }
        public virtual List<Song> Songs { get; set; } = new List<Song>();
    }
}
