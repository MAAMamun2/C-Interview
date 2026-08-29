using System;

public class ParkingAllocation
{
    public static int GetMinimumSlots(int largeSlots, int smallSlots, int buses, int cars)
    {
        
        if (buses > largeSlots)
            return -1;

        largeSlots -= buses;
        
        int carsInLargeSlots = Math.Min(cars / 3, largeSlots);
        cars -= carsInLargeSlots * 3;
        largeSlots -= carsInLargeSlots;
      
        if (cars > 0 && largeSlots > 0)
        {
            cars--;
            largeSlots--;
        }
        
        int carsInSmallSlots = Math.Min(cars, smallSlots);
        cars -= carsInSmallSlots;
      
        if (cars > 0)
            return -1;     
        int totalSlotsUsed = buses + carsInLargeSlots + carsInSmallSlots;

        return totalSlotsUsed;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(GetMinimumSlots(2, 12, 1, 4));
    }
}