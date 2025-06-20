namespace LambdaExample
{
	
	internal class Program
	{
		/// <summary>
		/// מדפיס הודעת הצלחה לקונסול.
		/// </summary>
		/// <param name="message"></param>
		public static void Success(string? message)
	{
		Console.WriteLine($"Success: {message}");
	}
		/// <summary>
		/// מכפיל שני מספרים שלמים ומחזיר את התוצאה.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static int Multiply(int a, int b)
		{
			return a * b;
		}

		static void Main(string[] args)
		{
			
			Action<string> PrintMessage = Success;
			PrintMessage("Hello from Lambda Expression!");
			
			// Lambda expressions example


			Func<int, int, int> Calc = Multiply;
			int result = Calc(5, 10);
			Console.WriteLine($"Result : {result}");
			// Lambda expression to add two numbers


		}
	}
}
