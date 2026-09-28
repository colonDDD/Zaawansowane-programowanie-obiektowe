using System;

class Enemy : Postac
{
    public int AttackPower { get; private set; }

    public Enemy(string name, int health, int attackPower, int level)
    {
        Name = name;
        Level = level;
        MaxHealth = health + level * 10;
        Health = MaxHealth;
        AttackPower = attackPower + level * 2;
    }

    public override void Attack(Postac target)
    {
        target.TakeDamage(AttackPower);
    }
}
