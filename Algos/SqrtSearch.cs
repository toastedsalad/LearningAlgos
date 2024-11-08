using System;

public class SqrtSearch
{
	// You have two crystal balls
	// Use sqrt algo as way to find which floor thrown off it would break.
	public static int Search(bool[] floors)
	{
		var breaks = true;
		// Lol this is not what were supposed to do.
		// We have an array of booleans and we need to find where the switch happens.

		var stepRange = (int)Math.Floor(Math.Sqrt(floors.Length));
		var i = stepRange;

		// We increment the array by jumping sqrt amount of ranges.
		// And record where the break happens.
		for (; i < floors.Length; i += stepRange)
		{
			if (floors[i] == breaks)
			{
				break;
			}
		}

		// Reset the i to the last jump start
		// I knew there was subtraction somehwere
		i -=  stepRange;

		// Here we create a new iterator which will only iterate through our range.
		// We also track if we are still within bounds of the array.
		for (int j = 0; j <= stepRange && i < floors.Length; j++, i++)
		{
				if (floors[i] == breaks)
				{
					return i;
				}
		}
		
		return -1;	
	}
}
