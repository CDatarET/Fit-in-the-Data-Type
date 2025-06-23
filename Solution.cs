using System;

public class Test
{
	public static void Main()
	{
		int cases = int.Parse(Console.ReadLine());
		
		for(int c = 0; c < cases; c++){
		    string[] inputs = Console.ReadLine().Split();
		    int n = int.Parse(inputs[0]);
		    int x = int.Parse(inputs[1]);
		    
		    while(x > n){
		        x = x - n - 1;
		    }
		    
		    Console.WriteLine(x);
		}
	}
}
