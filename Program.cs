// Polymorphism: satu List<Item> berisi berbagai jenis subclass
List<Item> inventory = new List<Item>
{
    new Item("Batu Biasa", 1, "Batu kecil yang tidak berguna"),
    new Weapon("Pedang Besi", 150, "Pedang standar para prajurit", 25),
    new Potion("Health Potion", 50, "Ramuan pemulih HP", 40),
    new Armor("Perisai Kayu", 80, "Perisai ringan dari kayu ek", 15),
    new LegendaryWeapon("Excalibur", 5000, "Pedang legendaris sang raja", 120, "Api Suci (+50% damage ke musuh gelap)")
};

Console.WriteLine("=== Menggunakan Semua Item di Inventory ===\n");

foreach (Item item in inventory)
{
    item.Use(); // method yang dipanggil menyesuaikan tipe asli object
    Console.WriteLine();
}