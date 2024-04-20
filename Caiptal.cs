class Caiptal
{
	static void Main()
	{
		System.Console.WriteLine("Enter A letter of your Choice:");
		char[] alp= System.Console.ReadLine();
	   
		if ((alp >= 65 && alp <= 90)|| (alp >= 97 && alp <= 122))
           System.Console.WriteLine(" Alphabet ");
 
       
        else if (alp >= 48 && alp <= 57)
            System.Console.WriteLine(" Digit ");
 
        
        else
            System.Console.WriteLine("Special Character");
	}
}