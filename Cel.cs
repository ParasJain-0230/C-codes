class Cel
{
	static void Main(){
	System.Console.Write("Enter Temprature in Farenite:");
	int fer = System.Convert.ToInt32(System.Console.ReadLine());
	double cel = ((fer-32)*5)/9;
	System.Console.Write(" Temprature in Celsiue:"+cel);

	   
	}
}