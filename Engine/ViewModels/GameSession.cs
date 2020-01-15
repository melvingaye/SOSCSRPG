using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Melvin";
            CurrentPlayer.CharacterClass = "Mage";
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 100;
            CurrentPlayer.HitPoints = 200;
            CurrentPlayer.Level = 1;
        }
    }
}
