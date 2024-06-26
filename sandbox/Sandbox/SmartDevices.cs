
public abstract class SmartDevice
{
    public string Name { get; set; }
    public bool IsOn { get; protected set; }
    public DateTime TurnedOnTime { get; protected set; }

    public SmartDevice(string name)
    {
        Name = name;
        IsOn = false;
    }

    public virtual void TurnOn()
    {
        if (!IsOn)
        {
            IsOn = true;
            TurnedOnTime = DateTime.Now;
        }
    }

    public virtual void TurnOff()
    {
        IsOn = false;
    }

    public TimeSpan GetOnDuration()
    {
        return IsOn ? DateTime.Now - TurnedOnTime : TimeSpan.Zero;
    }

    public override string ToString()
    {
        return $"{Name} is {(IsOn ? "on" : "off")}. On duration: {GetOnDuration().TotalMinutes:F2} minutes.";
    }
}