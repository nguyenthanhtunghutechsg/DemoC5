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


	}
}