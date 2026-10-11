public class Armor : Item
{
    protected int defensePower;

    public Armor(string itemName, int price, string description, int defensePower)
        : base(itemName, price, description)
    {
        this.defensePower = defensePower;
    }

    public override void Use()
    {
        Console.WriteLine($"[Armor] Kamu memakai {itemName}. Pertahanan bertambah {defensePower}.");
    }
}