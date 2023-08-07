using System;

namespace Migrations.Entites
{
    public class Student
    {
        public int Id { get; set; } 
        public string ?Name { get; set; }
        public ICollection<Section>Sections { get; set; }=new List<Section>();

    }


    public class Individual :Student {
    
         public string ?University { get; set; }
         public int YearOfGraduation { get; set; }
         public bool IsIntern { get; set; }
    }
    public class Coobrate :Student{
        public string ?Company { get; set; }
        public string ?JobTitle { get; set; }
    }
}
