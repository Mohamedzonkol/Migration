using System;
namespace Migrations.Entites
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }    
        public decimal Prise { get; set; }
        public ICollection<Section>? Sections { get; set; }=new List<Section>();
    }
}
