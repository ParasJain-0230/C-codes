class FibonacciExample  
   {  
    static void Main()  
      {  
         int n1=0,n2=1,n3,i,number;    
         System.Console.Write("Enter the number of elements: ");    
         number = int.Parse(System.Console.ReadLine());  
         System.Console.Write(n1+" "+n2+" ");   
         for(i=2;i<number;i++)  
         {    
          n3=n1+n2;    
          System.Console.Write(n3+" ");    
          n1=n2;    
          n2=n3;    
         }    
      }  
   }  
