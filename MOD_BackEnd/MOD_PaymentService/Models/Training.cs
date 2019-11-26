using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_PaymentService.Models
{
    public class Training
    {
        [Key]
        public string TrainingId { get; set; }
        [Required]
        [ForeignKey("Mentor")]
        public string MentorId { get; set; }
        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }
        [Required]
        [ForeignKey("Skills")]
        public string SkillId { get; set; }
        [Required]
        [Column(TypeName="Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Column(TypeName ="Date")]
    public DateTime EndDate { get; set; }
        [Required]

        public string timeslot { get; set; }
        [Required]

        public string status { get; set; }
        [Required]
        public string Progress { get; set; }
        [Required]
        public float rating { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
        public Skills Skills { get; set; }
        public IEnumerable<Payment> payments { get; set; }
    }
}
