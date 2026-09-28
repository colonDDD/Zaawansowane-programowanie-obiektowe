using System;

static class Game
{
    public static int BattlesCount { get; private set; }

    public static void RegisterBattle()
    {
        BattlesCount++;
    }

    public static Enemy ChooseEnemy()
    {
        Console.WriteLine("Choose enemy difficulty: 1 - Easy, 2 - Medium, 3 - Hard");
        string input = Console.ReadLine();

        if (input == "2")
            return new Enemy("Orc", 80, 12, 2);
        if (input == "3")
            return new Enemy("Dragon", 150, 20, 4);

        return new Enemy("Goblin", 50, 8, 1);
    }
}
