using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TrainingService.Models
{
    public class Payment
    {
        public string PaymentId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("Training")]
        public string TrainingId { get; set; }
       
        public int Amount { get; set; }
        [ForeignKey("Mentor")]
        public string MentorId { get; set; }
        public int Mentor_amount { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
        public Training Training { get; set; }

    }
}
