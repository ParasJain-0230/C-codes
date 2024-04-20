class Prime
   {  
    static void Main()
	{
	   System.Console.Write("enter a number: ");
	   int num = System.Convert.ToInt32(System.Console.ReadLine());
	   int flag=0;
	   for(int i=2;i<=num/2;i++){
	     if(num%i==0){
	        System.Console.Write("no is not prime");
	        flag=1;
	         break;
	        }
	   }
	   if(flag==0){
	   System.Console.Write("no is Prime");
	   }
    }  
}  
 