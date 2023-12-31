﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChampionList.Domain.Model
{
    public class Champion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int TrueLoveCounter { get; set; }
        public int LikedCounter { get; set; }
        public int TrashedCounter { get; set; }
        public ICollection<LikedChamp> LikedChamps { get; set; }
        public ICollection<TrashedChamp> TrashedChamps { get; set; }
    }
}
