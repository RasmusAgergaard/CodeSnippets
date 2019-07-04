using System;

namespace Inheritance
{
    public enum creatureTypes { Warrior, Monk, Archer, Thief, Giant, Wolf, Undead, Spider };

    public abstract class Creature
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public creatureTypes Type { get; set; }

        abstract public void TakeDamage(int damage);
        abstract public void Attack(Creature target);
    }

    public class Player : Creature
    {
        public Player(int health, int mana, int damage, creatureTypes type)
        {
            Health = health;
            Mana = mana;
            Damage = damage;
            Type = type;
        }

        public int Mana { get; set; }

        public override void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Type} has {Health} health left\n");
        }

        public override void Attack(Creature target)
        {
            Console.WriteLine($"{Type} attacks {target.Type}");
            target.TakeDamage(Damage);
        }
    }

    public class Enemy : Creature
    {
        public Enemy(int health, int damage, creatureTypes type)
        {
            Health = health;
            Damage = damage;
            Type = type;
        }

        public override void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Type} has {Health} health left\n");
        }

        public override void Attack(Creature target)
        {
            Console.WriteLine($"{Type} attacks {target.Type}");
            target.TakeDamage(Damage);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player(health: 80, mana: 50, damage: 10, type: creatureTypes.Monk);
            var player2 = new Player(health: 120, mana: 0, damage: 25, type: creatureTypes.Warrior);
            var enemy1 = new Enemy(health: 120, damage: 25, type: creatureTypes.Giant);
            var enemy2 = new Enemy(health: 120, damage: 25, type: creatureTypes.Undead);
            var enemy3 = new Enemy(health: 120, damage: 25, type: creatureTypes.Spider);

            //Pretended game logic
            player1.Attack(enemy1);
            player2.Attack(enemy1);

            enemy1.Attack(player2);
            enemy2.Attack(player2);
            enemy3.Attack(player2);
        }
    }
}
