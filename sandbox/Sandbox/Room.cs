
public class Room
{
    public string Name { get; set; }
    public List<SmartDevice> Devices { get; set; }

    public Room(string name)
    {
        Name = name;
        Devices = new List<SmartDevice>();
    }

    public void AddDevice(SmartDevice device)
    {
        Devices.Add(device);
    }

    public void TurnOnAllLights()
    {
        foreach (var device in Devices.OfType<SmartLight>())
        {
            device.TurnOn();
        }
    }

    public void TurnOffAllLights()
    {
        foreach (var device in Devices.OfType<SmartLight>())
        {
            device.TurnOff();
        }
    }

    public void TurnOnDevice(string deviceName)
    {
        var device = Devices.Find(d => d.Name == deviceName);
        device?.TurnOn();
    }

    public void TurnOffDevice(string deviceName)
    {
        var device = Devices.Find(d => d.Name == deviceName);
        device?.TurnOff();
    }

    public void TurnOnAllDevices()
    {
        foreach (var device in Devices)
        {
            device.TurnOn();
        }
    }

    public void TurnOffAllDevices()
    {
        foreach (var device in Devices)
        {
            device.TurnOff();
        }
    }

    public void ReportAllDevices()
    {
        Console.WriteLine($"Devices in {Name}:");
        foreach (var device in Devices)
        {
            Console.WriteLine(device);
        }
    }

    public void ReportOnDevices()
    {
        Console.WriteLine($"Devices that are on in {Name}:");
        foreach (var device in Devices.Where(d => d.IsOn))
        {
            Console.WriteLine(device);
        }
    }

    public void ReportLongestOnDevice()
    {
        var longestOnDevice = Devices.Where(d => d.IsOn).OrderByDescending(d => d.GetOnDuration()).FirstOrDefault();
        if (longestOnDevice != null)
        {
            Console.WriteLine($"Device on for the longest time in {Name}:");
            Console.WriteLine(longestOnDevice);
        }
        else
        {
            Console.WriteLine($"No devices are currently on in {Name}.");
        }
    }
}