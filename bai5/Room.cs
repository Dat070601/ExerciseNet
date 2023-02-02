public class Room
{
    public string? Category { get; set; }
    public int Price { get; set; }
    public Room(string category, int price)
    {
        Category = category;
        Price = price;
    }
}