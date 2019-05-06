using System;
using System.Collections.Generic;

namespace Inheritance
{
    public enum playerType { Warrior, Monk, Archer, Thief };
    public enum enemyType { Giant, Wolf, Undead, Spider}

    public class Creature
    {
        public int Health { get; set; }
    }

    public class Player : Creature
    {
        public Player(int health, int mana, playerType type)
        {
            Health = health;
            Mana = mana;
            Type = type;
        }

        public int Mana { get; set; }
        public playerType Type { get; set; }
    }

    public class Enemy : Creature
    {
        public Enemy(int health, enemyType type)
        {
            Health = health;
            Type = type;
        }

        public enemyType Type { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var players = new List<Player>();
            players.AddRange(new List<Player>
            {
                new Player(health: 80, mana: 50, type: playerType.Monk),
                new Player(health: 150, mana: 0, type: playerType.Warrior),
            });

            var enemies = new List<Enemy>();
            enemies.AddRange(new List<Enemy>
            {
                new Enemy(health: 250, type: enemyType.Giant),
                new Enemy(health: 80, type: enemyType.Undead),
                new Enemy(health: 30, type: enemyType.Spider)
            });

            Console.WriteLine("Players:");

            foreach (var player in players)
            {
                Console.WriteLine($"Type: {player.Type}, Health: {player.Health}, Mana: {player.Mana}");
            }

            Console.WriteLine("\nEnemies:");

            foreach (var enemy in enemies)
            {
                Console.WriteLine($"Type: {enemy.Type}, Health: {enemy.Health}");
            }
        }
    }

}
