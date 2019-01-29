using SchoolPoC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPoC.DAL.DbContexts
{
	public class SchoolPoCDbContext : DbContext
	{
		 public DbSet<Class> Classes { get; set; }
		 public DbSet<Teacher> Teachers { get; set; }
		 public DbSet<Student> Students { get; set; }
	}
}
