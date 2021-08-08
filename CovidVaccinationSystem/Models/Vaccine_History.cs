using System.ComponentModel.DataAnnotations;
using System;

namespace CovidVaccinationSystem.Models
{
    public class Vaccine_History
    {
        [Key]
        public int Vacc_Id                      {get;set;}
       
        public int   Pat_Id                      {get;set;}
        [Display(Name = "Vaccine Name")]
        public string   Vacc_Name                {get;set;}
        [Display(Name = "First Schedule Date")]
        public DateTime   Vacc_1_ScheduleDate    {get;set;}
        [Display(Name = "First Lot No")]
        public string   Vacc_1_LotNo             {get;set;}
        [Display(Name = "Second Schedule Date")]
        public DateTime   Vacc_2_ScheduleDate    {get;set;}
        [Display(Name = "Second Lot No")]
        public string Vacc_2_LotNo { get; set; }
        [Display(Name = "Patient Name")]
        public string Pat_Name { get; set; }
    }
}
