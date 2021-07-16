using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Practical_WAD.Models;

namespace Practical_WAD.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Practice")
        {
        }

        
        public DbSet<ClassRoom> ClassRooms { get; set; }

        public DbSet<Exam> Exams { get; set; }

        public DbSet<Faculty> Faculties { get; set; }

        public DbSet<Subject> Subjects { get; set; }
    }
}