class Swap
{
	static void Main()
	{
		System.Console.Write("Enter First Num:");
		int num1= System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.Write("Enter Second Num:");
		int num2= System.Convert.ToInt32(System.Console.ReadLine());
		int num3 = num1;
		num1 =num2;
		num2 =num3;
		System.Console.WriteLine("num1 is"+num1);
		System.Console.WriteLine("num2 is"+num2);
	}
}