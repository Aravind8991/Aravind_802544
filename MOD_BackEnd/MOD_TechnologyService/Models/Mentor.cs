using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TechnologyService.Models
{
    public class Mentor
    {
        [Key]

        public string MentorId { get; set; }
        [Required]
        public string MentorName { get; set; }
        [Required]
     [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(10)]
        public string MobileNo { get; set; }
        [Required]
       [MinLength(8)]
        public string Password { get; set; }
        [Required]
        
        public int Experience { get; set; }
        [Required]
        public string Skill { get; set; }
        [Required]
        public string TimeSlot { get; set; }
        public string Availability { get; set; }
       
        public bool Active { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> Payments { get; set; }

     

    }
}
