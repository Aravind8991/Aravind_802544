using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD_TrainingService.Models;

namespace MOD_TrainingService.Context
{
    public class TrainingContext:DbContext
    {
        public TrainingContext(DbContextOptions<TrainingContext> options) :
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
