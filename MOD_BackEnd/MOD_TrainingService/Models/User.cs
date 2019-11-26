using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TrainingService.Models
{
    public class User
    {
        [Key]
       
        public string UserId { get; set; }
        [Required]
      
        public string UserName { get; set; }
        [Required]
       [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(10)]
        public string MobilNo { get; set; }
        [Required]
        [MinLength(8)]
       
        public string Password { get; set; }
        
        public bool Active { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
    }
}
