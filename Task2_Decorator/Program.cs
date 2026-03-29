using Task2_Decorator;

class Program
{
    static void Main(string[] args)
    {
        IHero warrior = new Warrior();
        Console.WriteLine($"{warrior.GetDescription()} Power: {warrior.GetPower()}");

        // Декоруємо героя: меч + броня
        IHero warriorWithSword = new Sword(warrior);
        IHero warriorFullyEquipped = new Armor(warriorWithSword);

        Console.WriteLine($"{warriorFullyEquipped.GetDescription()} Power: {warriorFullyEquipped.GetPower()}");

        // Mage з артефактом і бронею
        IHero mage = new Mage();
        IHero mageWithArtifact = new Artifact(mage);
        IHero mageEquipped = new Armor(mageWithArtifact);

        Console.WriteLine($"{mageEquipped.GetDescription()} Power: {mageEquipped.GetPower()}");

        // Palladin з усім одразу
        IHero palladin = new Palladin();
        IHero palladinEquipped = new Sword(new Armor(new Artifact(palladin)));

        Console.WriteLine($"{palladinEquipped.GetDescription()} Power: {palladinEquipped.GetPower()}");
    }
}