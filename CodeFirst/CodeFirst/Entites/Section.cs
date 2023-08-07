using System;

namespace Migrations.Entites
{
    public class Section
    {
        public int Id { get; set; }
        public string ?SectioNname { get; set; }
        public int CourseId { get; set; }
        public Course ?Courses { get; set; }

        public int? InstructorId { get; set; }
        public Instructor? Instructors { get; set;}
        public int ScheduleId { get; set; }
        public Schedule ?Schedules { get; set; }
        public TimeSlot? TimeSlot { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();


    }
    public class TimeSlot
    {

        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public override string ToString()
        {
            return $"{StartTime.ToString("hh\\:mm")} - {EndTime.ToString("hh\\:mm")}";
        }
    }
}
