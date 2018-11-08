using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epione.Domain
{
    public class MedicalCurriculum
    {[Key]
        public int IdMedicalCurriculum { get; set; }
        public string justificatory { get; set; }
        public DateTime DateMC { get; set; }
        public string Description { get; set; }




        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }



        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }




    }
}
