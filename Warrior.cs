using System;

class Warrior : Postac
{
    public int Strength { get; private set; }

    public Warrior(string name)
    {
        Name = name;
        Level = 1;
        MaxHealth = 100;
        Health = MaxHealth;
        Strength = 15;
    }

    public override void Attack(Postac target)
    {
        int damage = Strength + Level * 2;
        target.TakeDamage(damage);
    }
}
