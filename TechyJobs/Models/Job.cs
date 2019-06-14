using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechyJobs.Models
{
    public class Job
    {
        public int JobId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Location { get; set; }

        public string Description { get; set; }
    }
}
