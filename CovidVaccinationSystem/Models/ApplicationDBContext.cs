using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CovidVaccinationSystem.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }
        public DbSet<Patient_Master> Patient_Master { get; set; }
        public DbSet<Vaccine_History> Vaccine_History { get; set; }
    }
}
