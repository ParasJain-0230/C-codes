class Cont
   {  
    static void Main()  {
        System.Console.Write("Enter any Number: ");
		int num=System.Convert.ToInt32(System.Console.ReadLine());
		int rem;
		int max=0;
		while(num>0)
		{
			num=num/10;
			int cub= rem*rem*rem;
		   if(cub>max)
			   max=cub; 
		   
		}
		System.Console.WriteLine(max);
      }  
   }  
 