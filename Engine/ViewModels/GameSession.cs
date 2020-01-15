using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
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

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = 0;
            CurrentLocation.Description = "This is your house";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/Home.png";
        }
    }
}