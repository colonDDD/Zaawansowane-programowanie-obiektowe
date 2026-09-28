using System;

class Program
{
    static void Main()
    {
        Postac hero = ChooseHero();

        while (true)
        {
            Console.WriteLine("Type 'Fight' to battle or 'Exit' to quit.");
            string input = Console.ReadLine();

            if (input.Equals("Exit", StringComparison.OrdinalIgnoreCase))
                break;

            if (input.Equals("Fight", StringComparison.OrdinalIgnoreCase))
            {
                Enemy enemy = Game.ChooseEnemy();
                Game.RegisterBattle();

                Console.WriteLine($"{hero.Name} vs {enemy.Name}");

                while (hero.IsAlive && enemy.IsAlive)
                {
                    hero.Attack(enemy);
                    Console.WriteLine($"{hero.Name} hits {enemy.Name}, enemy HP: {enemy.Health}");

                    if (!enemy.IsAlive)
                    {
                        Console.WriteLine("You won the battle.");
                        hero.GainLevel();
                        Console.WriteLine($"{hero.Name} reached level {hero.Level}.");
                        hero.HealToFull();
                        break;
                    }

                    enemy.Attack(hero);
                    Console.WriteLine($"{enemy.Name} hits {hero.Name}, hero HP: {hero.Health}");

                    if (!hero.IsAlive)
                    {
                        Console.WriteLine("You lost the battle.");
                        hero.HealToFull();
                        break;
                    }
                }
            }
        }

        Console.WriteLine("Game closed.");
    }

    static Postac ChooseHero()
    {
        Console.WriteLine("Choose hero: 1 - Warrior, 2 - Mage");
        string input = Console.ReadLine();
        return input == "2" ? new Mage("Mage") : new Warrior("Warrior");
    }
}
