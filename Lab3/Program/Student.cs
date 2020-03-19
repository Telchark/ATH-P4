using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Program
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Imie { get; set; }
        [Required]
        [MaxLength(255)]
        public string Nazwisko { get; set; }
    }
}