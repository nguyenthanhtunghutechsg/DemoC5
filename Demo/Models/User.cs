using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class User
    {
		private int iD;

		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string faculty;
		public string Faculty
		{
			get { return faculty; }
			set { faculty = value; }
		}
		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}		
		private string gmail;

		public string Gmail
		{
			get { return gmail; }
			set { gmail = value; }
		}

	}
}