namespace Practices.Coding.CSharp;

/*
 * 
 * All structs and built in value types like Int,Bool are sealed. 
 * Structs cannot inherit from other classes or structs.
 * 
 * 
 */
public readonly struct Device
{
    public readonly string DeviceType { get; init; }
    public readonly string Name { get; init; }
    public readonly int Serial { get; init; }

    public readonly int GetDeviceSerial()
    {
        return 0;
    }
    public Device(string deviceType, string name, int serial)
    {
        DeviceType = deviceType;
        Name = name;
        Serial = serial;
    }

    public override string ToString() => $"{DeviceType}-{Name}-{Serial}";
}
