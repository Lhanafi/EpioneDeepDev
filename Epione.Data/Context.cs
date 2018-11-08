using Epione.Data.Configuration;
using Epione.Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epione.Data
{
   public  class Context : IdentityDbContext<User, Tuser, int, Tlogin, Trole, Tclaim>
    {
        public static Context Create() { return new Context(); }
        public Context():base("name=machaine")
        {

        }
         static Context()
        {
            Database.SetInitializer<Context>(null);
        }
        public DbSet<Doctor> DoctorDbset { get; set; }
        public DbSet<Patient> PatientDbset { get; set; }
        public DbSet<Appointment> AppointmentDbset { get; set; }
        public DbSet<Consultation> ConsultaionDbset { get; set; }
        public DbSet<Consultation_Reasons> Consultaion_reasonsDbset { get; set; }
        public DbSet<MedicalCurriculum> MedicalCurriculumDbset { get; set; }
        public DbSet<Report> ReportDbset { get; set; }
        public DbSet<Chat> ChatDbset { get; set; }
        public DbSet<Medical_Question_Responce> Medical_Question_ResponceDbset { get; set; }
     //  public DbSet<User> UserDbset { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consultation>()
               .HasRequired(s => s.Report)
                .WithRequiredPrincipal(ad => ad.Consultation);

            //modelBuilder.Entity<Patient>()
            // .HasRequired(m => m.Curriculum)
            //  .WithRequiredPrincipal(bc => bc.Patient);

            //modelBuilder.Entity<MedicalCurriculum>()
            //    .HasRequired(p => p.Patient).WithRequiredPrincipal(c => c.CurriculumId);


            modelBuilder.Configurations.Add(new CurriculumConfiguration());


            modelBuilder.Configurations.Add(new UserConfiguration());


            //les config + conventions
        }
    }
}
