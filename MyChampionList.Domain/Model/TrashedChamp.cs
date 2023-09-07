using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChampionList.Domain.Model
{
    public class TrashedChamp
    {
        public int ChampionId { get; set; }
        public Champion Champion { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
