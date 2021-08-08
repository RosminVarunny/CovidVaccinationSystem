using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CovidVaccinationSystem.Models;

namespace CovidVaccinationSystem.Controllers
{
    public class VaccinationController : Controller
        
    {
        private readonly ApplicationDBContext _db;

        public VaccinationController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult VaccinationHistory(int Pat_Id)
        {
            var displayData = (from v in _db.Vaccine_History
                               join p in _db.Patient_Master on v.Pat_Id equals p.Pat_Id
                               where v.Pat_Id == Pat_Id
                               select new Vaccine_History
                               {
                                   Vacc_Id = v.Vacc_Id,
                                   Pat_Id = v.Pat_Id,
                                   Pat_Name = p.Pat_Name,
                                   Vacc_1_LotNo = v.Vacc_1_LotNo,
                                   Vacc_1_ScheduleDate = v.Vacc_1_ScheduleDate,
                                   Vacc_2_LotNo = v.Vacc_2_LotNo,
                                   Vacc_2_ScheduleDate = v.Vacc_2_ScheduleDate,
                                   Vacc_Name = v.Vacc_Name,
                               }).FirstOrDefault();
            if (displayData == null)
            {
                return View();
            }
            else
                return View(displayData);
        }
        public IActionResult PatientList()
        {
            var displayData = _db.Patient_Master.ToList();
            return View(displayData);
        }
        public IActionResult PatientAdd(int? Pat_Id)
        {
            if(Pat_Id != null)
            {
                var EditPatient = _db.Patient_Master.Where(x => x.Pat_Id == Pat_Id).FirstOrDefault();
                return View(EditPatient);
            }
            return View();
        }
        public IActionResult PatientDetails(int? Pat_Id)
        {
            if (Pat_Id != null)
            {
                var EditPatient = _db.Patient_Master.Where(x => x.Pat_Id == Pat_Id).FirstOrDefault();
                return View(EditPatient);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PatientAdd(Patient_Master patient_Master)
        {
            
            //if (ModelState.IsValid)
            {
                if (patient_Master.Pat_Id != 0)
                {
                    _db.Entry(patient_Master).State = EntityState.Modified;
                    await _db.SaveChangesAsync();
                }
                else
                {
                    _db.Add(patient_Master);
                    await _db.SaveChangesAsync();
                }
               
                return RedirectToAction("PatientList");
            }
            return View(patient_Master);
        }
        public IActionResult VaccinationAdd(int? Pat_Id,int? Vacc_Id)
        {
            if(Vacc_Id != null)
            {
                var EditPatient = _db.Vaccine_History.Where(x => x.Vacc_Id == Vacc_Id).FirstOrDefault();
                return View(EditPatient);
            }
            else
            {
                var EditPatient = _db.Vaccine_History.Where(x => x.Pat_Id == Pat_Id).FirstOrDefault();
                return View(EditPatient);
            }
            
        }
        public IActionResult VaccinationDetails(int? Vacc_Id, int Pat_Id)
        {
            if (Vacc_Id == null)
            {
                var displayData = (from v in _db.Vaccine_History
                                   join p in _db.Patient_Master on v.Pat_Id equals p.Pat_Id
                                   where v.Pat_Id == Pat_Id
                                   select new Vaccine_History
                                   {
                                       Vacc_Id = v.Vacc_Id,
                                       Pat_Id = v.Pat_Id,
                                       Pat_Name = p.Pat_Name,
                                       Vacc_1_LotNo = v.Vacc_1_LotNo,
                                       Vacc_1_ScheduleDate = v.Vacc_1_ScheduleDate,
                                       Vacc_2_LotNo = v.Vacc_2_LotNo,
                                       Vacc_2_ScheduleDate = v.Vacc_2_ScheduleDate,
                                       Vacc_Name = v.Vacc_Name,
                                   }).FirstOrDefault();
                if (displayData == null)
                {
                    return View();
                }
                else
                    return View(displayData);
            }
            else
            {
                var EditPatient = (from v in _db.Vaccine_History
                                   join p in _db.Patient_Master on v.Pat_Id equals p.Pat_Id
                                   where v.Pat_Id == Pat_Id
                                   select new Vaccine_History
                                   {
                                       Vacc_Id = v.Vacc_Id,
                                       Pat_Id = Pat_Id,
                                       Pat_Name = p.Pat_Name,
                                       Vacc_1_LotNo = v.Vacc_1_LotNo,
                                       Vacc_1_ScheduleDate = v.Vacc_1_ScheduleDate,
                                       Vacc_2_LotNo = v.Vacc_2_LotNo,
                                       Vacc_2_ScheduleDate = v.Vacc_2_ScheduleDate,
                                       Vacc_Name = v.Vacc_Name,
                                   }).FirstOrDefault();
                ViewBag.patid = Pat_Id;
                return View(EditPatient);
            }
        }
        [HttpPost]
        public async Task<IActionResult> VaccinationAdd(Vaccine_History vaccine_History)
        {
            if (ModelState.IsValid)
            {
                if (vaccine_History.Vacc_Id != 0)
                {
                    _db.Entry(vaccine_History).State = EntityState.Modified;
                    await _db.SaveChangesAsync();
                }
                else
                {
                    _db.Add(vaccine_History);
                    await _db.SaveChangesAsync();
                }

                return RedirectToAction("VaccinationHistory");
            }
            return View(vaccine_History);
        }
    }
}
