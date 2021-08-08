using System;
using System.ComponentModel.DataAnnotations;

namespace CovidVaccinationSystem.Models
{
    public class Patient_Master
    {
        [Key]
        public int Pat_Id { get; set; }
       [Display(Name = "Name")]
        public string    Pat_Name              {get;set;}
        [Display(Name = "Age")]
        public int    Pat_Age               {get;set;}
        [Display(Name = "Gender")]
        public string    Pat_Gender            {get;set;}
        [Display(Name = "Occupation")]
        public string    Pat_Occupation        {get;set;}
        [Display(Name = "DOB")]
        public DateTime    Pat_DOB               {get;set;}
        [Display(Name = "Vaccination Status")]
        public string    Pat_Vaccine_Status    {get;set;}
        [Display(Name = "Is Allergic")]
        public bool    Pat_IsAllergic        {get;set;}
        [Display(Name = "Allergies")]
        public string    Pat_Allergies         {get;set;}
        [Display(Name = "IsPregnant")]
        public bool    Pat_IsPregnant        {get;set;}
        [Display(Name = "Is Feeding Mother")]
        public bool    Pat_IsFeedingMother   {get;set;}
        [Display(Name = "Diseases")]
        public string    Pat_Diseases          {get;set;}
        [Display(Name = "Is Eligiable")]
        public bool    Pat_IsEligiable       {get;set;}
        [Display(Name = "Mobile")]
        public string    Pat_Mobile            {get;set;}
        [Display(Name = "Email")]
        public string    Pat_Email             {get;set;}
        [Display(Name = "Medicine Taking")]
        public string Pat_MedicineTaking { get; set; }
    }
}
