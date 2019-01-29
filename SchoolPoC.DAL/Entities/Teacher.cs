using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPoC.DAL.Entities
{
	public class Teacher
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public Class Class { get; set; }
	}
}
