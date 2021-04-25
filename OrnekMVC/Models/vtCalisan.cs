using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OrnekMVC.Models
{
    public class vtCalisan
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string isim { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime tarih { get; set; }

        [Range(13,65)]
        public int yas { get; set; }
    }
}
