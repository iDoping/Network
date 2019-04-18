using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Models
{
    public class MyAppContext : DbContext
    {
        public MyAppContext (DbContextOptions<MyAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyApp.Models.Movie> Movie { get; set; }

        public DbSet<MyApp.Models.StudentInfo> StudentInfo { get; set; }

        public DbSet<MyApp.Models.Attendance> Attendance { get; set; }

        public DbSet<MyApp.Models.PassOfWork> PassOfWork { get; set; }

        public DbSet<MyApp.Models.KindOfWork> KindOfWork { get; set; }

        public DbSet<MyApp.Models.GroupTable> GroupTable { get; set; }

        public DbSet<MyApp.Models.TableOfSpeciality> TableOfSpeciality { get; set; }

        public DbSet<MyApp.Models.DeskOfNew> DeskOfNew { get; set; }

        public DbSet<MyApp.Models.DisciplineInformation> DisciplineInformation { get; set; }

    }
}