using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PBO_Praktikum.StrukturData
{
    internal class Stukturkontak
    {
        [Key]
        public int id_fasilitas_gym { get; set; }
        [Required]
        [StringLength(50)]
        public string nama_orang { get; set; }
        [Required]
        [StringLength(50)]
        public string email_orang { get; set; }
        [Required]
        [StringLength(50)]
        public string no_tlp { get; set; }
    }
}
