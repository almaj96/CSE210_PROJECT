using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a house
        var house = new House();

        // Create rooms
        var livingRoom = new Room("Living Room");
        var bedroom = new Room("Bedroom");

        // Add devices to rooms
        livingRoom.AddDevice(new SmartLight("Living Room Light"));
        livingRoom.AddDevice(new SmartTV("Living Room TV"));
        bedroom.AddDevice(new SmartLight("Bedroom Light"));
        bedroom.AddDevice(new SmartHeater("Bedroom Heater"));

        // Add rooms to house
        house.AddRoom(livingRoom);
        house.AddRoom(bedroom);

        // Demonstrate functionality
        livingRoom.TurnOnAllLights();
        livingRoom.TurnOnDevice("Living Room TV");
        bedroom.TurnOnDevice("Bedroom Heater");

        System.Threading.Thread.Sleep(2000); // Wait for 2 seconds

        livingRoom.ReportAllDevices();
        bedroom.ReportOnDevices();
        livingRoom.ReportLongestOnDevice();

        livingRoom.TurnOffAllDevices();
        bedroom.TurnOffAllDevices();

        Console.WriteLine("All devices turned off:");
        livingRoom.ReportAllDevices();
        bedroom.ReportAllDevices();
    }
}
