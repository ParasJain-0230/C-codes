class Sub
{
	static void Main()
	{
		System.Console.WriteLine("Enter First Num:");
		int num1= System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("Enter Second Num:");
		int num2= System.Convert.ToInt32(System.Console.ReadLine());
		int sub= num1-num2;
		System.Console.WriteLine("Subttraction is" + sub);
	}
}