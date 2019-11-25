using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GloriousProject.Models;
using System.Net;
using System.IO;
using SimpleJSON;
using GloriousProject.Services;

namespace GloriousProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly EntityFrameworkDbContext _context;
        private readonly Timetable _timetable;
        public HomeController(EntityFrameworkDbContext context, Timetable timetable)
        {
            _context = context;
            _timetable = timetable;
        }

        public IActionResult Index(int week = 0)
        {
            DateTime startDay = DateTime.Now.AddDays(-((int)DateTime.Today.DayOfWeek) + 1)
                .AddDays(week * 7);
            ViewBag.Week = week;
            List<Lesson> lessons = Mapper.Mapper.RuzLessonToLesson(
                _timetable.GetLessons(startDay, startDay.AddDays(6), "rvmaryatkin@edu.hse.ru"));
            List<Lesson> deleted = _context.Lessons.Where(l => l.Status == "Delete").ToList();
            foreach (var les in lessons.ToList())
            {
                foreach (var del in deleted)
                {
                    if (del == les)
                        lessons.Remove(les);
                }
            }
            lessons.AddRange(_context.Lessons.Where(l => l.Status == "Add"));
            return View(lessons.OrderBy(x => x.Date).ThenBy(x => x.EndLesson).ToList());
        }

        [HttpGet]
        public IActionResult Delete(string date, string time, string lecturer, string status,
            int id = 0)
        {
            if (status == "Add")
            {
                var lesson = _context.Lessons.Find(id);
                if (lesson != null)
                {
                    _context.Lessons.Remove(lesson);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            _context.Lessons.Add(new Lesson
            {
                Date = date,
                BeginLesson = time,
                Lecturer = lecturer,
                Status = "Delete"
            });
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult LessonsAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LessonsAdd(Lesson lesson)
        {
            _context.Lessons.Add(lesson);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
