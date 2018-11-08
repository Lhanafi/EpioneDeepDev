using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epione.Domain
{
   public class Medical_Question_Responce
    {
        [Key]
        public int IdQuestion { get; set; }
        public string Question { get; set; }
        public string responce { get; set; }

    }
}
