using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Den.Models
{
    public class Setting
    {
        public int ID { get; set; }
        [MaxLength(30)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(30)]
        public string Mail { get; set; }
        [MaxLength(255)]
        public string ImgLink { get; set; }
    }
}
