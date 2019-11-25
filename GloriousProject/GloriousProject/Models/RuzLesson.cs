using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloriousProject.Models
{
    public class RuzLesson
    {
        public string auditorium { get; set; }
        public int auditoriumAmount { get; set; }
        public int auditoriumOid { get; set; }
        public string author { get; set; }
        public string beginLesson { get; set; }
        public string building { get; set; }
        public string createddate { get; set; }
        public string date { get; set; }
        public string dateOfNest { get; set; }
        public int dayOfWeek { get; set; }
        public string dayOfWeekString { get; set; }
        public string detailInfo { get; set; }
        public string discipline { get; set; }
        public int disciplineOid { get; set; }
        public string disciplineinplan { get; set; }
        public int disciplinetypeload { get; set; }
        public string endLesson { get; set; }
        public int group { get; set; }
        public int groupOid { get; set; }
        public int hideincapacity { get; set; }
        public bool isBan { get; set; }
        public string kindOfWork { get; set; }
        public string lecturer { get; set; }
        public int lecturerOid { get; set; }
        public int lessonNumberEnd { get; set; }
        public int lessonNumberStart { get; set; }
        public string modifieddate { get; set; }
        public string parentschedule { get; set; }
        public string stream { get; set; }
        public int streamOid { get; set; }
        public int subGroup { get; set; }
        public int subGroupOid { get; set; }
    }
}
