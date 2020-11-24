using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(countX("xhixhix"));
	}
	
	public static int countX(string s)
	{
		if(s.Length == 0) return 0;
		else{
			if(s[0] == 'x') 
			{
				return 1 + countX(s.Remove(0,1));
			}
			return 0 + countX(s.Remove(0,1));
		}
	}
}
