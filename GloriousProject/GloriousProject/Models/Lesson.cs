using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloriousProject.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Auditorium { get; set; }
        public string BeginLesson { get; set; }
        public string EndLesson { get; set; }
        public string Building { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Lecturer { get; set; }
        public string Stream { get; set; }
        public string Status { get; set; }

        public static bool operator ==(Lesson a, Lesson b)
        {
            if (a.Date == b.Date && a.Lecturer == b.Lecturer && a.BeginLesson == b.BeginLesson)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Lesson a, Lesson b)
        {
            if (a.Date != b.Date || a.Lecturer != b.Lecturer || a.BeginLesson != b.BeginLesson)
            {
                return true;
            }
            return false;
        }
    }
}
