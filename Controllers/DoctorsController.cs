using System.Linq;
using AdminPanelTutorial.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
namespace AdminPanelTutorial
{
    public class DoctorsController : Controller
    {
        MyDbContext _dbContext;
        public DoctorsController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {
            return View(_dbContext.Doctors.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDoctor(Doctor doctor)
        {
            _dbContext.Doctors.Add(doctor);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Doctors");
        }

        [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                Doctor doctor = _dbContext.Doctors.Where(s => s.Id == id).First();
                _dbContext.Doctors.Remove(doctor);
                _dbContext.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }

        public ActionResult Update(int id)
        {
            return View(_dbContext.Doctors.Where(s => s.Id == id).First());
        }

        [HttpPost]
        public ActionResult UpdateDoctor(Doctor doctor)
        {
            Doctor d = _dbContext.Doctors.Where(s => s.Id == doctor.Id).First();
            d.Name = doctor.Name;
            d.Phone = doctor.Phone;
            d.Specialist = doctor.Specialist;
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Doctors");
        }
    }
}