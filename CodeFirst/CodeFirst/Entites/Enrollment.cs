using System;


namespace Migrations.Entites
{
    public class Enrollment
    {
        public int StudentId { get; set; }
        public int SectionId { get; set; }
        public Section Sections { get; set; } = null!;
        public Student Students { get; set; } = null!;
    }
}
