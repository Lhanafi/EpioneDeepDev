using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epione.Domain
{

   public  class Doctor:User
    {
        public int registration_number { get; set; }
        public string Office_address { get; set; }
        public  string speciality  { get; set; }
        public virtual ICollection<Consultation_Reasons> ConsultaionReasons { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<Consultation> Consultations { get; set; }



        public virtual ICollection<MedicalCurriculum> MedicalCurriculums { get; set; }




    }
}
