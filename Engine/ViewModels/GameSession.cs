using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Melvin";
            CurrentPlayer.CharacterClass = "Mage";
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 100;
            CurrentPlayer.HitPoints = 200;
            CurrentPlayer.Level = 1;
           
            WorldFactory worldFactory = new WorldFactory();
            CurrentWorld = worldFactory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(-1, -1);
        }
    }
}