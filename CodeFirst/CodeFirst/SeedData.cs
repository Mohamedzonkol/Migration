using Migrations.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public static class SeedData
    {
         public static List<Course> load_courses()
        {
            return new List<Course> {

            new Course() {Id=1 , Name="Math",Prise=15.00m },
            new Course() {Id=2 , Name="Physics",Prise=180.55m },
            new Course() {Id=3 , Name="Prog",Prise=5.22m },
            new Course() {Id=4 , Name="Arabic",Prise=7.25m },
            new Course() {Id=5 , Name="English",Prise=30.00m },
             };

        }
        public static List<Enrollment> load_Enrollments()
        {
            return new List<Enrollment> {
            new Enrollment() {StudentId=1 , SectionId=6 },
            new Enrollment() {StudentId=2 , SectionId=6 },
            new Enrollment() {StudentId=3 , SectionId=7 },
            new Enrollment() {StudentId=4 , SectionId=7 },
            new Enrollment() {StudentId=5 , SectionId=8 },
            new Enrollment() {StudentId=6 , SectionId=8 },
            new Enrollment() {StudentId=7 , SectionId=9 },
            new Enrollment() {StudentId=8 , SectionId=9},
            new Enrollment() {StudentId=9 , SectionId=10 },
            new Enrollment() {StudentId=10 , SectionId=10 },
             };
        }
        public static List<Instructor> load_Instructors()
        {
            return new List<Instructor> {

            new Instructor() {Id=1 , Name="Mohamed",OfficeId=1 },
            new Instructor() {Id=2 , Name="Ahmed"  ,OfficeId=2 },
            new Instructor() {Id=3 , Name="Karem"  ,OfficeId=3},
            new Instructor() {Id=4 , Name="Nade"   ,OfficeId=4},
            new Instructor() {Id=5 , Name="Rasha"  ,OfficeId=5 },
             };
        }
        public static List<Office> load_Ofiicess()
        {
            return new List<Office> {

            new Office() {Id=1 , OfficeName="Off_04",OfficeLocation="Buldinag A" },
            new Office() {Id=2 , OfficeName="Off_05",OfficeLocation="Buldinag B" },
            new Office() {Id=3 , OfficeName="Off_06",OfficeLocation="Buldinag S"},
            new Office() {Id=4 , OfficeName="Off_07",OfficeLocation="Buldinag W"},
            new Office() {Id=5 , OfficeName="Off_08",OfficeLocation="Buldinag Z" },
             };
        }
        public static List<Schedule> load_Schedules()
        {
            return new List<Schedule> {

                   new Schedule() { Id = 1 , Title="Daily"      ,SUN=true,MON=true,TUE=true,WED=true,THU=true,FRI=false,SAT=false },
                   new Schedule() { Id = 2 , Title="DayAfterDay" ,SUN=true,MON=false,TUE=true,WED=false,THU=true,FRI=false,SAT=false },
                   new Schedule() { Id = 3,  Title="Twice"      ,SUN=false,MON=true,TUE=false,WED=true,THU=false,FRI=false,SAT=false },
                   new Schedule() { Id = 4 , Title="Weekend"    ,SUN=false,MON=false,TUE=false,WED=false,THU=false,FRI=true,SAT=true },
                   new Schedule() { Id = 5 , Title="Compact",SUN=true,MON=true,TUE=true,WED=true,THU=true,FRI=true,SAT=true },

        };
        }

        public static List<Section> LoadSections()
        {
            return new List<Section>
            {
            new Section { Id = 1, SectioNname = "S_MA1", CourseId = 1, InstructorId = 1, ScheduleId = 1, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") } },
            new Section { Id = 2, SectioNname = "S_MA2", CourseId = 1, InstructorId = 2, ScheduleId = 3, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("14:00:00"), EndTime = TimeSpan.Parse("18:00:00") } },
            new Section { Id = 3, SectioNname = "S_PH1", CourseId = 2, InstructorId = 1, ScheduleId = 4, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("15:00:00") } },
            new Section { Id = 4, SectioNname = "S_PH2", CourseId = 2, InstructorId = 3, ScheduleId = 1, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("12:00:00") } },
            new Section { Id = 5, SectioNname = "S_CH1", CourseId = 3, InstructorId = 2, ScheduleId = 1, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("16:00:00"), EndTime = TimeSpan.Parse("18:00:00") } },
            new Section { Id = 6, SectioNname = "S_CH2", CourseId = 3, InstructorId = 3, ScheduleId = 2, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") } },
            new Section { Id = 7, SectioNname = "S_BI1", CourseId = 4, InstructorId = 4, ScheduleId = 3, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("11:00:00"), EndTime = TimeSpan.Parse("14:00:00") } },
            new Section { Id = 8, SectioNname = "S_BI2", CourseId = 4, InstructorId = 5, ScheduleId = 4, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("14:00:00") } },
            new Section { Id = 9, SectioNname = "S_CS1", CourseId = 5, InstructorId = 4, ScheduleId = 4, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("16:00:00"), EndTime = TimeSpan.Parse("18:00:00") } },
            new Section {Id = 10, SectioNname = "S_CS2", CourseId = 5, InstructorId = 5, ScheduleId = 3, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("12:00:00"), EndTime = TimeSpan.Parse("15:00:00") } },
            new Section {Id = 11, SectioNname = "S_CS3", CourseId = 5, InstructorId = 4, ScheduleId = 5, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("09:00:00"), EndTime = TimeSpan.Parse("11:00:00") } }
            };
        }
        //public static List<Student> LoadStudents()
        //    {
        //        return new List<Student>
        //   {
        //        new Student() { Id = 1, Name = "Fatima"},
        //        new Student() { Id = 2, Name = "Noor" ,},
        //        new Student() { Id = 3, Name = "Omar" ,},
        //        new Student() { Id = 4, Name = "Huda" ,},
        //        new Student() { Id = 5, Name = "Amira" },
        //        new Student() { Id = 6, Name = "Zainab"},
        //        new Student() { Id = 7, Name = "Yousef"},
        //        new Student() { Id = 8, Name = "Layla" },
        //        new Student() { Id = 9, Name = "Mohamme"},
        //        new Student() { Id = 10,Name = "Samira" }
        //   };
        //     }
        public static List<Coobrate> LoadCorporates() => new()
        {
            new Coobrate { Id = 2, Name = "Noor Saleh", Company = "ABC", JobTitle = "Developer" },
            new Coobrate { Id = 4, Name = "Huda Ahmed", Company = "ABC", JobTitle = "QA" },
            new Coobrate { Id = 7, Name = "Yous Farid", Company = "EFG", JobTitle = "Developer" },
            new Coobrate { Id = 8, Name = "Layl Mustafa", Company = "EFG", JobTitle = "QA" }
        };
        public static List<Individual> LoadIndividuals() => new()
        {
            new Individual { Id = 1, Name = "Fatim Ali",University = "XYZ", YearOfGraduation = 2024, IsIntern = false },
            new Individual { Id = 3, Name = "Omar ussef", University = "POQ", YearOfGraduation = 2023, IsIntern = true },
            new Individual { Id = 5, Name = "Amira ariq", University = "POQ", YearOfGraduation = 2025, IsIntern = false },
            new Individual { Id = 6, Name = "Zaina Ismail", University = "POQ", YearOfGraduation = 2023, IsIntern = true },
            new Individual { Id = 9, Name = "Mohamed  Adel", University = "XYZ", YearOfGraduation = 2024, IsIntern = false },
            new Individual { Id = 10, Name = "Samir Nabil", University = "XYZ", YearOfGraduation = 2024, IsIntern = false }
        };


    }
}
