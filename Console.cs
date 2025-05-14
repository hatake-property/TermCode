namespace TermCode
{
	internal class Color
	{
		public static void Reset()
		{
			System.Console.BackgroundColor = System.ConsoleColor.White;
			System.Console.ForegroundColor = System.ConsoleColor.Black;
		}

		public static void Invert()
		{
			System.ConsoleColor c = System.Console.BackgroundColor;
			System.Console.BackgroundColor = System.Console.ForegroundColor;
			System.Console.ForegroundColor = c;
		}
	}
}
