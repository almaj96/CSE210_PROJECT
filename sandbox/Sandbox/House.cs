
public class House
{
    public List<Room> Rooms { get; set; }

    public House()
    {
        Rooms = new List<Room>();
    }

    public void AddRoom(Room room)
    {
        Rooms.Add(room);
    }
}