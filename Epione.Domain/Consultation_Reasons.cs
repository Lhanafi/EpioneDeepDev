using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epione.Domain
{
   public  class Consultation_Reasons
    {[Key]
        public int IdConsultationReasons { get; set; }
        public string Reason_name { get; set; }
        public float Time_slot { get; set; }
        public float Price { get; set; }
        public virtual Doctor Doctor  { get; set; }


    }
}
