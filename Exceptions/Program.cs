namespace Exceptions
{
	
	internal class Program
	{
		public static void ExceptionExample()
		{
			
				int[] arr = { 1, 2, 3 };
				Console.WriteLine(arr[5]); // This will throw an IndexOutOfRangeException
		
		}

		public static Grade CreateGrade(int score)
		{
			Grade? grade = null;

				grade = new Grade(score);
				return grade; //אם הציון תקין, מחזיר את האובייקט Grade
			
		}


		static void Main(string[] args)
		{
			// Exception handling example

			ExceptionExample();

			Grade grade = CreateGrade(105);



		}
	}
}
