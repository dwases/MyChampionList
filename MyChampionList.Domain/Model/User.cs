using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChampionList.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int TrueLoveId { get; set; }
        public ICollection<LikedChamp> LikedChamps { get; set; }
        public ICollection<TrashedChamp> TrashedChamps { get; set; }
    }
}
