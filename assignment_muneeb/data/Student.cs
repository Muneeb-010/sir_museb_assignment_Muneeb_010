using System.ComponentModel.DataAnnotations;

namespace assignment_muneeb.data
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Major { get; set; }
        public int Standing { get; set; }
        public ICollection<Enrolled> Enrolled { get; set; }
    }
}
