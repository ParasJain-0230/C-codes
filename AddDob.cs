class AddDob
{
	static void Main()
	{
	     int i;
		 int sum =0;
		 i=0;
		 while(i<5){
		System.Console.WriteLine("Enter "+(i+1) +" Num:");
		int num = System.Convert.ToInt32(System.Console.ReadLine());
		sum += 2*num;
		i=i+1;
		}
		System.Console.WriteLine(sum);
		
	}
}