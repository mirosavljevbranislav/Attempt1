using CodeFirt.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirt.Data
{
    public class Grade
    {
        public int Id { get; set; }
        
        [Range(5,10)]
        public int GradeName { get; set; }

        public Student Student { get; set; }

        public int StudentId { get; set; }

        public Subject Subject { get; set; }

        public int SubjectId { get; set; }


        //public ICollection<Student> Students { get; set; }
    }
}
