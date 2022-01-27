using Den.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Den.ViewModels
{
    public class HomeVm
    {
        public List<Setting> Settings { get; set; }
        public List<Social> Socials { get; set; }
    }
}
