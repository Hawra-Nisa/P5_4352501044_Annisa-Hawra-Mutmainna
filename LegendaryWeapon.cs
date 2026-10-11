// sealed: class ini ada di ujung hierarki dan tidak boleh diwarisi lagi
public sealed class LegendaryWeapon : Weapon
{
    private string specialEffect;

    public LegendaryWeapon(string itemName, int price, string description,
                           int attackPower, string specialEffect)
        : base(itemName, price, description, attackPower)
    {
        this.specialEffect = specialEffect;
    }

    public override void Use()
    {
        Console.WriteLine($"[Legendary Weapon] {itemName} bersinar! Kekuatan serang: {attackPower}.");
        Console.WriteLine($"  Efek spesial aktif: {specialEffect}");
    }
}