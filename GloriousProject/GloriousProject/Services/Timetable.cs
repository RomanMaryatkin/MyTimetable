using GloriousProject.Models;
using SimpleJSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GloriousProject.Services
{
    public class Timetable
    {
        private string API { get; set; } = "https://www.hse.ru/api/timetable/lessons?";

        private static List<RuzLesson> ruzLessons { get; set; } = new List<RuzLesson>();

        public List<RuzLesson> GetLessons(DateTime fromDate, DateTime toDate,
            string email)
        {
            WebRequest request;
            request = WebRequest.Create(API + "fromdate=" +
                fromDate.ToString("yyyy.MM.dd") + "&todate=" + toDate.ToString("yyyy.MM.dd")
                + "&email=" + email);
            Stream stream;
            stream = request.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(stream);

            string content;
            content = objReader.ReadToEnd();

            var N = JSON.Parse(content);
            int count = N["Count"].AsInt;

            for (int i = 0; i < count; i++)
            {
                RuzLesson ruzLesson = new RuzLesson
                {
                    auditorium = N["Lessons"][i]["auditorium"].Value,
                    auditoriumAmount = N["Lessons"][i]["auditoriumAmount"].AsInt,
                    auditoriumOid = N["Lessons"][i]["auditoriumOid"].AsInt,
                    author = N["Lessons"][i]["author"].Value,
                    beginLesson = N["Lessons"][i]["beginLesson"].Value,
                    building = N["Lessons"][i]["building"].Value,
                    createddate = N["Lessons"][i]["createddate"].Value,
                    date = N["Lessons"][i]["date"].Value,
                    dateOfNest = N["Lessons"][i]["dateOfNest"].Value,
                    dayOfWeek = N["Lessons"][i]["dayOfWeek"].AsInt,
                    dayOfWeekString = N["Lessons"][i]["dayOfWeekString"].Value,
                    detailInfo = N["Lessons"][i]["detailInfo"].Value,
                    discipline = N["Lessons"][i]["discipline"].Value,
                    disciplineOid = N["Lessons"][i]["disciplineOid"].AsInt,
                    disciplineinplan = N["Lessons"][i]["disciplineinplan"].Value,
                    disciplinetypeload = N["Lessons"][i]["disciplinetypeload"].AsInt,
                    endLesson = N["Lessons"][i]["endLesson"].Value,
                    group = N["Lessons"][i]["group"].AsInt,
                    groupOid = N["Lessons"][i]["groupOid"].AsInt,
                    hideincapacity = N["Lessons"][i]["hideincapacity"].AsInt,
                    isBan = N["Lessons"][i]["isBan"].AsBool,
                    kindOfWork = N["Lessons"][i]["kindOfWork"].Value,
                    lecturer = N["Lessons"][i]["lecturer"].Value,
                    lecturerOid = N["Lessons"][i]["lecturerOid"].AsInt,
                    lessonNumberEnd = N["Lessons"][i]["lessonNumberEnd"].AsInt,
                    lessonNumberStart = N["Lessons"][i]["lessonNumberStart"].AsInt,
                    modifieddate = N["Lessons"][i]["modifieddate"].Value,
                    parentschedule = N["Lessons"][i]["parentschedule"].Value,
                    stream = N["Lessons"][i]["stream"].Value,
                    streamOid = N["Lessons"][i]["streamOid"].AsInt,
                    subGroup = N["Lessons"][i]["subGroup"].AsInt,
                    subGroupOid = N["Lessons"][i]["subGroupOid"].AsInt,
                };

                ruzLessons.Add(ruzLesson);
            }

            return (ruzLessons);
        }
    }
}
