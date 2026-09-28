using System;

class Mage : Postac
{
    public int Mana { get; private set; }

    public Mage(string name)
    {
        Name = name;
        Level = 1;
        MaxHealth = 70;
        Health = MaxHealth;
        Mana = 50;
    }

    public override void Attack(Postac target)
    {
        int damage = 10 + Mana / 5 + Level;
        Mana = Math.Max(0, Mana - 5);
        target.TakeDamage(damage);
    }
}
