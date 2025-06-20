using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
	public static class ExtentionExample
	{

		#region Extension Methods
		public static void MessageToIsrael(this string message)
		{
			// מדפיס הודעה לקונסול
			Console.WriteLine($"!דבל ורדסת :פמארט אישנהמ לארשיל העדוה");
		}
		
		#endregion
	}
}
