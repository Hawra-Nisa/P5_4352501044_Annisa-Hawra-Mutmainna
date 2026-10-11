// Base class untuk semua item dalam game RPG
public class Item
{
    protected string itemName;
    protected int price;
    protected string description;

    public Item(string itemName, int price, string description)
    {
        this.itemName = itemName;
        this.price = price;
        this.description = description;
    }

    // virtual: boleh di-override oleh subclass
    public virtual void Use()
    {
        Console.WriteLine($"Kamu menggunakan item {itemName}.");
        Console.WriteLine($"  Deskripsi: {description} (Harga: {price} gold)");
    }
}