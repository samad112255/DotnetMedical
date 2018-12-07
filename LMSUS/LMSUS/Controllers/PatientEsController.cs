using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LMSUS.Models;

namespace LMSUS.Controllers
{
    public class PatientEsController : Controller
    {
        private readonly LMSUSContext _context;

        public PatientEsController(LMSUSContext context)
        {
            _context = context;
        }

        // GET: PatientEs
        public async Task<IActionResult> Index()
        {
            var Patients = from pa in _context.PatientE
                           join pr in _context.PatientReqE
                           on pa.PaIdE equals pr.PaId
                           join ins in _context.Insurance
                           on pa.InsId equals ins.InsId
                           join refd in _context.RefDoctor
                           on pr.PreDocId equals refd.DocId
                           select new
                           {
                               pa.PaIdE,
                               pr.PreAccNo,
                               pr.PreReqNo,
                               pa.PaSsn,
                               pa.DateOfBirth,
                               pa.PaLastName,
                               pa.PaFirstName,
                               refd.DocCode,
                               refd.DocFirstName,
                               refd.DocLastName,
                               ins.InsName,
                               pr.PreAccDate
                           };


            return View(await Patients.ToListAsync());
        }

        // GET: PatientEs/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientE = await _context.PatientE
                .FirstOrDefaultAsync(m => m.PaIdE == id);
            if (patientE == null)
            {
                return NotFound();
            }

            return View(patientE);
        }

        // GET: PatientEs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PatientEs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaIdE,PaSsn,PaLastName,PaFirstName,Age,PaAddress,PaChartNo,PaPhone,PaFax,PaSex,PaEmail,DateOfBirth,ZipId,Status,InsId,InsNo,GroupNumber")] PatientE patientE)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patientE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details));
            }
            return View(patientE);
        }

        // GET: PatientEs/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientE = await _context.PatientE.FindAsync(id);
            if (patientE == null)
            {
                return NotFound();
            }
            return View(patientE);
        }

        // POST: PatientEs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("PaIdE,PaSsn,PaLastName,PaFirstName,Age,PaAddress,PaChartNo,PaPhone,PaFax,PaSex,PaEmail,DateOfBirth,ZipId,Status,InsId,InsNo,GroupNumber")] PatientE patientE)
        {
            if (id != patientE.PaIdE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patientE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientEExists(patientE.PaIdE))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details));
            }
            return View(patientE);
        }

        // GET: PatientEs/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientE = await _context.PatientE
                .FirstOrDefaultAsync(m => m.PaIdE == id);
            if (patientE == null)
            {
                return NotFound();
            }

            return View(patientE);
        }

        // POST: PatientEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var patientE = await _context.PatientE.FindAsync(id);
            _context.PatientE.Remove(patientE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Details));
        }

        private bool PatientEExists(long id)
        {
            return _context.PatientE.Any(e => e.PaIdE == id);
        }
    }
}
