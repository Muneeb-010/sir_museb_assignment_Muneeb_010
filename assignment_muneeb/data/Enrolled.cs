﻿using System.ComponentModel.DataAnnotations;

namespace assignment_muneeb.data
{
    public class Enrolled
    {
        [Key]
        public int Eid { get; set; }
        public Class Class { get; set; }
        public int Sid { get; set; }
        public Student Student { get; set; }
        public ICollection<Mark> Marks { get; set; }
    }
}
