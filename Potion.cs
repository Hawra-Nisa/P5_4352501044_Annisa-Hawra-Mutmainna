public class Potion : Item
{
    protected int healAmount;

    public Potion(string itemName, int price, string description, int healAmount)
        : base(itemName, price, description)
    {
        this.healAmount = healAmount;
    }

    public override void Use()
    {
        Console.WriteLine($"[Potion] Kamu meminum {itemName}. HP dipulihkan sebanyak {healAmount}.");
    }
}