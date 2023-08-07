using System;
namespace Migrations.Entites
{
    public class Office
    {
        public int Id { get; set; }
        public string ?OfficeName { get; set; }    
        public string ?OfficeLocation { get; set; }
        public Instructor? Instructors { get; set; }  
    }

}
