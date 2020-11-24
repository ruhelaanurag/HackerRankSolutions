using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(powerN(3,3));//27
	}
	
	public int powerN(int base, int n) {
  if(n ==0) return 1;
  
  return base * powerN(base, n-1);
}
}
