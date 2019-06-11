using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechyJobs.Models
{
    public class Recruiter
    {
        public int RecruiterId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Company { get; set; }

        public string Detials { get; set; }
    }
}
