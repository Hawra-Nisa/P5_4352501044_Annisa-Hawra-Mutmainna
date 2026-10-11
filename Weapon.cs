public class Weapon : Item
{
    protected int attackPower;

    // Constructor chaining: field warisan diisi lewat base(...)
    public Weapon(string itemName, int price, string description, int attackPower)
        : base(itemName, price, description)
    {
        this.attackPower = attackPower;
    }

    public override void Use()
    {
        Console.WriteLine($"[Weapon] Kamu menyerang dengan {itemName}! Kekuatan serang: {attackPower}.");
    }
}