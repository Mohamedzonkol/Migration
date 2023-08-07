using System;

namespace Migrations.Entites
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int OfficeId { get; set; }
        public Office ?Offices { get; set; }

        public ICollection<Section> Sections { get; set; }=new List<Section>();

    }
}
