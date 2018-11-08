using Epione.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epione.Data.Configuration
{
    class CurriculumConfiguration : EntityTypeConfiguration<MedicalCurriculum> 

    {

        public CurriculumConfiguration()
        {

            HasKey(cu => cu.IdMedicalCurriculum);
            HasRequired(p => p.Patient)
            .WithMany(c => c.MedicalCurriculums)
            .HasForeignKey(p=>p.PatientId).
            WillCascadeOnDelete(false);

            HasKey(cu => cu.IdMedicalCurriculum);
            HasRequired(p => p.Doctor)
            .WithMany(c => c.MedicalCurriculums)
            .HasForeignKey(p => p.DoctorId).
            WillCascadeOnDelete(false);

        }

    }
}
