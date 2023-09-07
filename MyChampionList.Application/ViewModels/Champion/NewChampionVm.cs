using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChampionList.Application.ViewModels.Champion
{
    public class NewChampionVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int RoleId { get; set; }
    }
}
