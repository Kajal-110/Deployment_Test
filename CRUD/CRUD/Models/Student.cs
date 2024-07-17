using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Student
    {
        public int Id { set; get; }
        
        public string? Name { set; get; }
        
        public string? Address { set; get; }
        
        public string? Age { set; get; }
        
    }
}
