namespace TermCode
{
	internal class Desktop
	{
		public static void Write(int height){
			for(int i = 0; i < height; i ++)
			{
				Console.WriteLine();
			}
		}
	}

	internal class InfoVar
	{
		public static void Write()
		{
			Color.Invert();
			for(int i = 0; i < System.Console.WindowWidth; i ++)
			{
				System.Console.Write(" ");
			}
			Color.Invert();
			System.Console.WriteLine();
		}
	}
}
