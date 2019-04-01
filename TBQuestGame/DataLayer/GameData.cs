using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;
using System.Collections.ObjectModel;

namespace TBQuestGame.DataLayer
{
    public static class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                ID = 1,
                Name = "Joseph",
                playerClass = Player.PlayerClass.Warrior,
                Health = 100,
                LocationId = 0,
                Souls = 0,
                NPCType = Player.NpcType.Player,
                PlayerLevel = 1,

            };
        }
        public static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "You are an Undead. Once a human, you were inflicted with the Curse of the Undead and locked away to the North in the Undead Asylum. You waste your days away locked up, trying desperately trying to maintain your sanity and keep yourself from going Hollow.",
                "Until one day you look up from your cell to see a knight, dressed with the traditional garb of Astora, staring at you through the hole in the ceiling. Silently, he drops a key into the middle of your cell before disappearing",
                "The key unlocks your cell door, and you're free to explore the rest of the asylum."
            };
        }
        public static GameMapCoordinates InitialGameMapLocation()
        {
            return new GameMapCoordinates() { Row = 0, Column = 0 };
        }

        //public static Location InitialGameMapLocation()
        //{

        //    return new Location()
        //    {
        //        Id = 0,
        //        Name = "Northern Undead Asylum",
        //        Description = "The Undead Asylum is a prison, with countless undead roaming through it. Some of them not even behind bars, yet their minds so far gone that escaping doesn't even cross their minds. ",
        //        Accessible = true,
        //        ModifyExperiencePoints = 1000
        //    };
        //}

        public static Map GameMap()
        {
            int rows = 3;
            int columns = 4;

            Map gameMap = new Map(rows, columns);

            gameMap.MapLocations[0, 0] = new Location()
            {
                Id = 0,
                Name = "Northern Undead Asylum",
                Description = "The Undead Asylum is a prison, with countless undead roaming through it. Some of them not even behind bars, yet their minds so far gone that escaping doesn't even cross their minds. ",
                Accessible = true,
                ModifyExperiencePoints = 1000,
                
            };

            gameMap.MapLocations[1, 0] = new Location()
            {
                Id = 1,
                    Name = "Firelink Shrine",
                    Description = "You arrive at Firelink Shrine as a servant of the Goddess Velka flies you there. Once home to an extravagant holy building, it now sits in ruins as a gathering hub for many travelers. From here many paths are visible, including paths to a decrepit crypt, a haunted city, a valley home to drakes, and a waterway passage into the kingdom.",
                    Accessible = true,
                    ModifyExperiencePoints = 1000
            };
                gameMap.MapLocations[2, 1] = new Location()
                {
                    Id = 2,
                    Name = "Undead Burg",
                    Description = "The sewer system that leads into the Undead Burg. It seems to be your best path to the first Bell of Awakening in the Undead Parish",
                    Accessible = true,
                    ModifyExperiencePoints = 500
                };
                gameMap.MapLocations[2, 2] = new Location()
                {
                    Id = 3,
                    Name = "Darkroot Garden",
                    Description = "You find yourself in a town of undead, mindlessly wandering around, attacking whenever you get near. ",
                    Accessible = true,
                    ModifyExperiencePoints = 500
                };
                gameMap.MapLocations[1, 1] = new Location()
                {
                    Id = 6,
                    Name = "Undead Parish",
                    Description = "Home to the church where the first Bell of Awakening resides. Also leads back to Firelink Shrine and the Darkroot Garden",
                    Accessible = false,
                    ModifyExperiencePoints = 1000
                };
                gameMap.MapLocations[1, 2] = new Location()
                {
                    Id = 4,
                    Name = "Lower Undead Burg",
                    Description = "On the way to the Undead Parish, you find yourself going through the tower. Only, halfway through a gigantic Tauros Demon jumps out from an unseen location",
                    Accessible = true,
                    ModifyExperiencePoints = 1500
                };

                //new Location()
                //{
                //    Id = 6,
                //    Name = "Undead Parish",
                //    Description = "Home to the church where the first Bell of Awakening resides. Also leads back to Firelink Shrine and the Darkroot Garden",
                //    Accessible = false,
                //    ModifyExperiencePoints = 1000
                //};



            return gameMap;
        }

    }
}
