using Gym;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data.DataContext
{
    public class GymData:DbContext
    {
       public DbSet<gymEquipment> equipments { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Subscribers> subscribers { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Gym_DB");
        }

        

    }
}
