using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epione.Domain
{
   public class Patient :User
    {
       public string Social_Number { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<Consultation> Consultations { get; set; }


        public virtual ICollection<MedicalCurriculum> MedicalCurriculums { get; set; }
    }
}
