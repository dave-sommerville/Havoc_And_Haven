using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havoc_And_Haven.Models
{
        public class CrisisEventVM
    {
        public int CrisisId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        // The mechanics of the crisis events and battles will need to be refined 
        public virtual ICollection<User> Villains { get; set; }
        public virtual ICollection<User> Heroes { get; set; }
        public bool IsResolved { get; set; } = false;
        public int LocationId { get; set; }
        public Location Location { get; set; }
        //public Battle ResultingBattle { get; set; }
    }
}
