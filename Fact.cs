class Fact
{
	static void Main()
	{
		System.Console.Write("Enter Number for Factorial:");
		int num= System.Convert.ToInt32(System.Console.ReadLine());
		int fact=1;
		int i=1;
		while(i<=num){
		fact=fact*i;
		i=i+1;
		}
		System.Console.WriteLine("Factorial of "+num+" is"+fact);
	}
}