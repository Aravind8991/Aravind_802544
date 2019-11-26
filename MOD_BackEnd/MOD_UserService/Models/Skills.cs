using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_UserService.Models
{
    public class Skills
    {
        [Key]
        public string SkillId { get; set; }
        [Required]
        [StringLength(50)]
        public string SkillName { get; set; }
        [Required]
        public string TOC { get; set; }
        [Required]
        public double Fees { get; set; }
        [Required]
        public string Duration { get; set; }
        public IEnumerable<Training> Trainings { get; set; }

    }
}
