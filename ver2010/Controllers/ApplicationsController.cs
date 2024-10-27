using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ver2010.Data;
using ver2010.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ver2010.Controllers
{
    [Authorize] // Chỉ cho phép người dùng đã đăng nhập
    public class ApplicationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ApplicationsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Applications
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "Account");
            }

            var applications = await _context.Application
                .Include(a => a.JobPost)
                .Where(a => a.UserId == userId)
                .ToListAsync();

            return View(applications);
        }



        // GET: Applications/Create
        // Hiển thị trang ứng tuyển cho một JobPost cụ thể
        public async Task<IActionResult> Create(int jobPostId)
        {
            var jobPost = await _context.JobPost.FindAsync(jobPostId);
            if (jobPost == null)
            {
                return NotFound();
            }

            // Truyền thông tin JobPost vào ViewBag để hiển thị trên form
            ViewBag.JobPostName = jobPost.JobName;
            ViewBag.JobPostId = jobPost.Id;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,Gender,Age,Location,Email,Description,JobPostId")] Application application)
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                ModelState.AddModelError("", "Unable to get UserId. Please log in and try again.");
                return View(application);
            }

            application.UserId = userId;
            application.Status = "Pending";


            _context.Add(application);
            await _context.SaveChangesAsync();
            ViewBag.JobPostName = (await _context.JobPost.FindAsync(application.JobPostId))?.JobName;

            return RedirectToAction("Index", "JobPosts");


            //return View(application);
        }

        // GET: Applications/Edit/5 (Optional: Nếu bạn muốn cho phép chỉnh sửa đơn ứng tuyển)
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }

            var jobPost = await _context.JobPost.FindAsync(application.JobPostId);
            ViewBag.JobPostName = jobPost.JobName;
            ViewBag.JobPostId = jobPost.Id;

            return View(application);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Gender,Age,Location,Email,Description,Status,JobPostId")] Application application)
        {
            if (id != application.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var existingApplication = await _context.Application.FindAsync(id);
                    if (existingApplication == null)
                    {
                        return NotFound();
                    }

                    existingApplication.FullName = application.FullName;
                    existingApplication.Gender = application.Gender;
                    existingApplication.Age = application.Age;
                    existingApplication.Location = application.Location;
                    existingApplication.Email = application.Email;
                    existingApplication.Description = application.Description;
                    existingApplication.Status = application.Status;

                    _context.Update(existingApplication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(application);
        }



        private bool ApplicationExists(int id)
        {
            return _context.Application.Any(e => e.Id == id);
        }

        // POST: Applications/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var application = await _context.Application.FindAsync(id);
            if (application != null)
            {
                _context.Application.Remove(application);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application
                .Include(a => a.JobPost)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }


    }
}
