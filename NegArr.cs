class NegArr{
	static void Main(){
		int count=0;
		System.Console.Write("Enter Base Value :");
		int b1 = System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.Write("Enter Sub Value :");
		int s = System.Convert.ToInt32(System.Console.ReadLine());
		
		int [,]arr=new int[b1,s];
		
		for(int x=0;x<arr.GetLength(0);x++){
			for(int y=0;y<arr.GetLength(1);y++){
				System.Console.Write("["+x+"] ["+y+"]:" );
				arr[x,y]=System.Convert.ToInt32(System.Console.ReadLine());
				if(arr[x,y]<0)
				 count++;
			}
			System.Console.WriteLine();
		}
		for(int i=0;i<arr.GetLength(0);i++){
			for(int j=0;j<arr.GetLength(1);j++){
				System.Console.Write(" "+arr[i,j]);
				
			}
			System.Console.WriteLine();
		}
			System.Console.WriteLine(count);
	}
}