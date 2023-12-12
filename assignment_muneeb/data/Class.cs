using System.ComponentModel.DataAnnotations;

namespace assignment_muneeb.data
{
    public class Class
    {
        [Key]
        public int Cid { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public int Fid { get; set; }
        public Faculty Faculty { get; set; }
        public ICollection<Enrolled> Enrolled { get; set; }
    }
}
