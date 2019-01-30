using SchoolPoC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPoC.Business.Repositories
{
	public class PoCRepository
	{
		public IEnumerable<Class> GetClasses()
		{
			return new List<Class>();
		}

		public IEnumerable<Teacher> GetTeachers()
		{
			return new List<Teacher>();
		}
		public IEnumerable<Student> GetStudents()
		{
			return new List<Student>();
		}

        
    }
}
