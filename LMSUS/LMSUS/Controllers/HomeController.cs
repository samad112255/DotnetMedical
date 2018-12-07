using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LMSUS.Models;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LMSUS.Controllers
{
    [AllowAnonymous]

    public class HomeController : Controller
    {
        private readonly LMSUSContext _context;
        public static DateTime? fromDate = DateTime.Now.Date, toDate = DateTime.Now.Date;
        public static string searchvalue = null;
        public static bool firsttime = true;
        public static IQueryable<GridData> PatientsData;
        public static City allCities;
        public static ZipCode allZipcodes;

        public static string sorting = null;
        public HomeController(LMSUSContext context)
        {
            _context = context;


        }

        [HttpGet]
        public async Task<IActionResult> Index(int? page, string currentFilter, DateTime? currentDate, string sortOrder, string search, DateTime? fromdate, DateTime? todate)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.AccnoSortParm = string.IsNullOrEmpty(sortOrder) ? "accno_desc" : "accno_asce";
            ViewBag.ReqnoSortParm = string.IsNullOrEmpty(sortOrder) ? "reqno_desc" : "reqno_asce";
            ViewBag.dobSortParm = string.IsNullOrEmpty(sortOrder) ? "dob_desc" : "dob_asce";
            ViewBag.LNameSortParm = string.IsNullOrEmpty(sortOrder) ? "lname_desc" : "lname_asce";
            ViewBag.FNameSortParm = string.IsNullOrEmpty(sortOrder) ? "fname_desc" : "fname_asce";
            ViewBag.DocNameSortParam = string.IsNullOrEmpty(sortOrder) ? "doc_desc" : "doc_asce";
            ViewBag.InsSortParm = string.IsNullOrEmpty(sortOrder) ? "ins_desc" : "ins_asce";
            ViewBag.AccDateSortParm = string.IsNullOrEmpty(sortOrder) ? "acc_date_desc" : "acc_date_asce";
            ViewBag.AccDateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
           
            ViewBag.CurrentFilter = search;

            var Patients = from pa in _context.PatientE.AsNoTracking()
                           join pr in _context.PatientReqE.AsNoTracking()
                           on pa.PaIdE equals pr.PaId
                           join ins in _context.Insurance.AsNoTracking()
                           on pa.InsId equals ins.InsId
                           join refd in _context.RefDoctor.AsNoTracking()
                           on pr.PreDocId equals refd.DocId
                           orderby pr.PreAccDate
    
                           select new GridData
                           {
                               PaIdE = pa.PaIdE,
                               PreAccNo = pr.PreAccNo,
                               PreReqNo = pr.PreReqNo,
                               PaSsn = pa.PaSsn,
                               DateOfBirth = pa.DateOfBirth,
                               PaLastName = pa.PaLastName,
                               PaFirstName = pa.PaFirstName,
                               DocCode = refd.DocCode,
                               DocLastName = refd.DocFirstName,
                               DocFirstName = refd.DocLastName,
                               InsCode = ins.InsCode,
                               PreAccDate = pr.PreAccDate,
                               PreDrawnDate = pr.PreDrawnDate
                           };


            if (string.IsNullOrEmpty(search) && page >= 1)
            {
                ViewBag.searching = searchvalue;
            }
            else
            {
                if (string.IsNullOrEmpty(search) && page == null)
                {
                    searchvalue = search;
                    ViewBag.searching = searchvalue;
                }
                else
                {
                    searchvalue = search;
                    ViewBag.searching = searchvalue;
                }
            }


            if (fromdate != null && todate != null)
            {
                fromDate = fromdate;
                toDate = todate;
                ViewBag.fromdate = fromdate;
                ViewBag.todate = toDate;

                Patients = Patients
                    .Where(s => s.PreAccDate >= fromDate && s.PreAccDate <= toDate);
            }
            else
            {
                if (fromdate == null && todate != null)
                {
                    fromDate = fromdate;
                    ViewBag.fromdate = fromDate;
                    toDate = todate;
                    ViewBag.todate = toDate;

                    Patients = Patients
                         .Where(s => s.PreAccDate <= toDate);
                }
                else
                {
                    if (fromdate != null && todate == null)
                    {
                        fromDate = fromdate;
                        ViewBag.fromdate = fromDate;
                        toDate = todate;
                        ViewBag.todate = toDate;

                        Patients = Patients
                     .Where(s => s.PreAccDate >= fromDate);
                    }
                    else
                    {
                  
                        if (fromdate == null && todate == null && (page != null || search != null || sortOrder != null))
                        {
                           
                            ViewBag.fromdate = fromDate;
                            ViewBag.todate = toDate;
                            if (ViewBag.fromdate != null && ViewBag.todate != null)
                            {
                                Patients = Patients
                            .Where(s => s.PreAccDate >= fromDate && s.PreAccDate <= toDate);
                            }
                            else
                            {
                                Patients = Patients.OrderBy(s => s.PreAccDate);
                            }
                        }
                        else
                        {
                            if (firsttime)
                            {
                                ViewBag.fromdate = fromDate;
                                ViewBag.todate = toDate;
                                Patients = Patients
                        .Where(s => s.PreAccDate >= fromDate && s.PreAccDate <= toDate);
                                firsttime = false;
                            }
                            else
                            {
                                fromDate = fromdate;
                                toDate = todate;
                                ViewBag.fromdate = fromDate;
                                ViewBag.todate = toDate;
                                Patients = Patients.OrderBy(s => s.PreAccDate);
                            }
                              
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(searchvalue))
            {
                Patients = Patients
                    .Where(s => s.PaLastName.Contains(searchvalue)
               || s.PaFirstName.Contains(searchvalue)
               || s.PreAccNo.ToString().Contains(searchvalue)
               || s.PreReqNo.Contains(searchvalue)
               || s.PreDrawnDate.ToString().Contains(searchvalue)
               || s.PaSsn.Contains(searchvalue)
               || s.DocFirstName.Contains(searchvalue)
               || s.InsCode.Contains(searchvalue)
               || s.PaSsn.Contains(searchvalue));
            }

            switch (sortOrder)
            {
                case "accno_desc":
                    Patients = Patients.OrderByDescending(s => s.PreAccNo);
                    break;
                case "accno_asce":
                    Patients = Patients.OrderBy(s => s.PreAccNo);
                    break;
                case "reqno_desc":
                    Patients = Patients.OrderByDescending(s => s.PreReqNo);
                    break;
                case "reqno_asce":
                    Patients = Patients.OrderBy(s => s.PreReqNo);
                    break;
                case "ssn_desc":
                    Patients = Patients.OrderByDescending(s => s.PaSsn);
                    break;
                case "ssn_asce":
                    Patients = Patients.OrderBy(s => s.PaSsn);
                    break;
                case "dob_desc":
                    Patients = Patients.OrderByDescending(s => s.DateOfBirth);
                    break;
                case "dob_asce":
                    Patients = Patients.OrderBy(s => s.DateOfBirth);
                    break;
                case "lname_desc":
                    Patients = Patients.OrderByDescending(s => s.PaLastName);
                    break;
                case "lname_asce":
                    Patients = Patients.OrderBy(s => s.PaLastName);
                    break;
                case "fname_desc":
                    Patients = Patients.OrderByDescending(s => s.PaFirstName);
                    break;
                case "fname_asce":
                    Patients = Patients.OrderBy(s => s.PaFirstName);
                    break;
                case "doc_desc":
                    Patients = Patients.OrderByDescending(s => s.DocFirstName);
                    break;
                case "doc_asce":
                    Patients = Patients.OrderBy(s => s.DocFirstName);
                    break;
                case "ins_desc":
                    Patients = Patients.OrderByDescending(s => s.InsCode);
                    break;
                case "ins_asce":
                    Patients = Patients.OrderBy(s => s.InsCode);
                    break;
                case "acc_date_desc":
                    Patients = Patients.OrderByDescending(s => s.PreAccDate);
                    break;
                case "acc_date_asce":
                    Patients = Patients.OrderBy(s => s.PreAccDate);
                    break;
                case "col_date_desc":
                    Patients = Patients.OrderByDescending(s => s.PreDrawnDate);
                    break;
                case "col_date_asce":
                    Patients = Patients.OrderBy(s => s.PreDrawnDate);
                    break;
                
                default:  // Accession ascending 
                    Patients = Patients.OrderBy(s => s.PreAccNo);
                    break;
            }

            var filteredPatients = await Patients.ToListAsync();
            var pager = new Pager(filteredPatients.Count(), page);
            var viewModel = new Sspagination
            {

                GridPatients = filteredPatients.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                Pager = pager
            };

            return View(viewModel);
        }

        [AllowAnonymous]
        public IActionResult Edit(long id)
        {


            var patients = _context.PatientE
                .AsNoTracking()
                .SingleOrDefault(i => i.PaIdE == id);
            var req = _context.PatientReqE
                .AsNoTracking()
                .SingleOrDefault(i => i.PaId == id);
            var insu = _context.Insurance
                .AsNoTracking()
               .SingleOrDefault(i => i.InsId == patients.InsId);
            var assignedTests = _context.PatientReqTestE
                .AsNoTracking()
                                .Where(i => i.PreId == req.PreIdE)
                                .ToList();
            var Doctor = _context.RefDoctor
                .AsNoTracking()
                 .SingleOrDefault(i => i.DocId == req.PreDocId);

            var zipcode = _context.ZipCode
                           .AsNoTracking()
                           .SingleOrDefault(i => i.ZipId == patients.ZipId);

            

            ViewBag.insurancess = new SelectList(_context.Insurance
               .AsNoTracking()
               .Select(i => new
               {
                   i.InsId,
                   i.InsCode
               })
               .ToList(), "InsId", "InsCode");
            ViewBag.doctorss = new SelectList(_context.RefDoctor
              .AsNoTracking()
              .Select(i => new
              {
                  i.DocId,
                  i.DocCode,
                  i.DocFirstName,
                  i.DocLastName
              })
              .ToList(), "DocId", "DocLastName");



            EditPatient ep = new EditPatient
            {
                PatientE = patients,
                PatientReqE = req,
                Insurance = insu,
                PatientReqTestEs = assignedTests,
                RefDoctor = Doctor,
     
                Zipcode = zipcode
            };


            return View(ep);
        }

        [HttpPost]
        public ActionResult Edit(EditPatient epatient)
        {

            var patients = _context.PatientE
                .AsNoTracking()
                .SingleOrDefault(i => i.PaIdE == epatient.PatientE.PaIdE);
            var req = _context.PatientReqE
                .AsNoTracking()
                .SingleOrDefault(i => i.PaId == epatient.PatientE.PaIdE);
         

            patients = epatient.PatientE;
            req.PreDocId = epatient.PatientReqE.PreDocId;

            if (ModelState.IsValid)
            {
                _context.PatientE.Update(patients);
                _context.PatientReqE.Update(req);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));

        }
        [AllowAnonymous]
        public IActionResult PatientTests(decimal id)
        {
            var data = _context.ClinicalTest
                .AsNoTracking()
                .SingleOrDefault(i => i.TestId == id);
            return Json(data);
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

     
        public async Task<IActionResult> Zipcodes(long id)
        {
            var zipcodes = _context.ZipCode
             .AsNoTracking()
             .SingleOrDefaultAsync(z => z.ZipCode1 == id.ToString());

            return Json(await zipcodes);
        }
        [HttpPost]
        public string SaveTests([FromBody] List<PatientReqTestE> tests)
        {
            if (tests.Count == 1 && tests[0].TgpsCode == null && tests[0].TgpsName == null)
            {
                var test = _context.PatientReqTestE
                        .Where(i => i.PreId == tests[0].PreId).ToList();

                _context.PatientReqTestE.RemoveRange(test);
                _context.SaveChanges();
                return "not saved";
            }
            else
            {
                var test = _context.PatientReqTestE
                    .Where(i => i.PreId == tests[0].PreId).ToList();

                _context.PatientReqTestE.RemoveRange(test);
                _context.PatientReqTestE.AddRange(tests);
                _context.SaveChanges();
                return "saved";
            }

        }
      
        [AllowAnonymous]
        public IActionResult Insurances(long id)
        {
            var data = _context.Insurance
                .AsNoTracking().
                SingleOrDefault(i => i.InsId == id);
            return Json(data);
        }
        public IActionResult DoctorInfo(decimal id)
        {
            var data = _context.RefDoctor
                .AsNoTracking().
                SingleOrDefault(i => i.DocCode == id);
            return Json(data);
        }
        public async Task<IActionResult> Tests()
        {
            var data = from c in _context.ClinicalTest.AsNoTracking()
                       select new ClinicalTestDropdownViewModel
                       {
                           TestId = c.TestId,
                           TestCode = c.TestCode
                       };
            return Json(await data.ToListAsync());
        }
        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
