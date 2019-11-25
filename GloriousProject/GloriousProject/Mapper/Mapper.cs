using GloriousProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloriousProject.Mapper
{
    public class Mapper
    {
        public static Lesson RuzLessonToLesson(RuzLesson ruzLesson)
        {
            return new Lesson
            {
                Auditorium = ruzLesson.auditorium,
                BeginLesson = ruzLesson.beginLesson,
                Building = ruzLesson.building,
                Date = ruzLesson.date,
                EndLesson = ruzLesson.endLesson,
                Lecturer = ruzLesson.lecturer,
                Name = ruzLesson.discipline,
                Status = "FromJson",
                Stream = ruzLesson.stream,
                Type = ruzLesson.kindOfWork
            };
        }

        public static List<Lesson> RuzLessonToLesson(List<RuzLesson> ruzLesson)
        {
            List<Lesson> lessons = new List<Lesson>();
            foreach (var i in ruzLesson)
            {
                lessons.Add(RuzLessonToLesson(i));
            }
            return lessons;
        }
    }
}
