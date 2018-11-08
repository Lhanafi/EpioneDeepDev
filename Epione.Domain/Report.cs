using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epione.Domain
{
   public class Report
    {
        [Key]
        public int IdReport { get; set; }
        public DateTime report_date { get; set; }
        public string content { get; set; }
       // [ForeignKey("Consultation")]
        public virtual Consultation Consultation { get; set; }
    }
}
