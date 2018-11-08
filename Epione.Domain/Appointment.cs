using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epione.Domain
{
   public  class Appointment
    {
            [Key]
        public int IdAppointment { get; set; }
        public string reason { get; set; }
        public string Opt_Msg { get; set; }
        public DateTime Date_Appointment { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }



    }
}
