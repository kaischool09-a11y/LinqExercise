using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise.Data
{
	public class Monkey
	{
		//שם הקוף
		public string Name
		{
			get; set;
		}
		//מיקום
		public string Location
		{
			get; set;
		}
		//פרטים נוספים
		public string Details
		{
			get; set;
		}
		//קישור לתמונה
		public string ImageUrl
		{
			get; set;
		}

		public override string ToString()
		{
			return $"Name:{Name}, Location: {Location}";
		}
	}
}
