using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD_TechnologyService.Models;

namespace MOD_TechnologyService.Context
{
    public class SkillContext:DbContext
    {
        public SkillContext(DbContextOptions<SkillContext> options) :
          base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Training> Trainings { get; set; }
    }
}
