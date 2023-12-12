using System.ComponentModel.DataAnnotations;

namespace assignment_muneeb.data
{
    public class Mark
    {
        [Key]
        public int MarkId { get; set; }
        public int EnrolledCid { get; set; }
        public Enrolled Enrolled { get; set; }
       
    }
}
