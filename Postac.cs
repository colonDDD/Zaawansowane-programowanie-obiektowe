using System;

abstract class Postac
{
    public string Name { get; protected set; }
    public int Level { get; protected set; }
    public int Health { get; protected set; }
    public int MaxHealth { get; protected set; }

    public abstract void Attack(Postac target);

    public virtual void TakeDamage(int damage)
    {
        Health = Math.Max(0, Health - damage);
    }

    public bool IsAlive => Health > 0;

    public void HealToFull()
    {
        Health = MaxHealth;
    }

    public void GainLevel()
    {
        Level++;
        MaxHealth += 10;
        Health = MaxHealth;
    }
}
