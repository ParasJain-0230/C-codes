class Swapwit
{
	static void Main()
	{
		System.Console.Write("Enter First Num:");
		int num1= System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.Write("Enter Second Num:");
		int num2= System.Convert.ToInt32(System.Console.ReadLine());
		num1 =num1+num2;
		num2 =num1-num2;
		num1 =num1-num2;
		System.Console.WriteLine("num1 is"+num1);
		System.Console.WriteLine("num2 is"+num2);
	}
}