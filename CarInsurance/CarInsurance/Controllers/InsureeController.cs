using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.EnterpriseServices;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.Views.ViewModel;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {

            if (ModelState.IsValid)
            {
                decimal quote = CalculateQuote(insuree);
                insuree.Quote = quote;

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        public static decimal CalculateQuote(Insuree insuree)
        {
            const decimal monthlyPayment = 50m;
            const decimal moneyXtraAge18 = 100m;
            const decimal moneyXtraAge1925 = 50m;
            const decimal moneyXtra25Dollars = 25m;
            const decimal moneyXtraForTickets = 10m;
            decimal total = 0;
            int insureeAge = DateTime.Now.Year - insuree.DateOfBirth.Year;
            if (insureeAge <= 18)
            {
                total = monthlyPayment + moneyXtraAge18;
            }
            else if (insureeAge >= 19 && insureeAge <=25)
            {
                total = monthlyPayment + moneyXtraAge1925;
            }
            else if (insureeAge > 25)
            {
                total = monthlyPayment + moneyXtra25Dollars;
            }

            if (insuree.CarYear < 2000)
            {
                total += moneyXtra25Dollars;
            }
            else if(insuree.CarYear > 2015)
            {
                total += moneyXtra25Dollars;
            }


            if(insuree.CarMake.ToLower() == "porsche")
            {
                total += moneyXtra25Dollars;
            }
            if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera")
            {
                total += moneyXtra25Dollars;
            }

            if(insuree.SpeedingTickets != 0)
            {
                total += (insuree.SpeedingTickets * moneyXtraForTickets);
            }

            if(insuree.DUI)
            {
                total += (0.25m * total);
            }
            if(insuree.CoverageType)
            {
                total += (0.5m * total);
            }
            return total;
        }



        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                decimal quote = CalculateQuote(insuree);
                insuree.Quote = quote;
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                List<Insuree> insurees = db.Insurees.ToList();
                List<AdminInsureeVm> adminInsureeVms = new List<AdminInsureeVm>();
                foreach (Insuree insuree in insurees)
                {
                    AdminInsureeVm adminInsureeVm = new AdminInsureeVm();
                    adminInsureeVm.Id = insuree.Id;
                    adminInsureeVm.FirstName = insuree.FirstName;
                    adminInsureeVm.LastName = insuree.LastName;
                    adminInsureeVm.EmailAddress = insuree.EmailAddress;
                    adminInsureeVm.Quote = insuree.Quote;
                    adminInsureeVms.Add(adminInsureeVm);
                }
                return View(adminInsureeVms);
            }
          
        }
    }
}
