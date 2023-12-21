using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Student : User
    {
		private int mSSV;

		public int MSSV
		{
			get { return mSSV; }
			set { mSSV = value; }
		}

		private string classStudent;

		public string ClassStudent
		{
			get { return classStudent; }
			set { classStudent = value; }
		}


	}
}