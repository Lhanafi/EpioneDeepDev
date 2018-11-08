using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epione.Domain
{
   public  class Consultation
    {
        [Key]
        public int IdConsultation { get; set; }
        public DateTime Consultation_Date { get; set; }
        public string Remarks { get; set; }
        public float Rating { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
       // [ForeignKey("Report")]
        public virtual Report Report { get; set; }

    }
}
