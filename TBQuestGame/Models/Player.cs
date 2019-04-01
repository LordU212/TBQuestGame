using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Player : Character
    {
        public enum PlayerClass
        {
            Warrior,
            Cleric,
            Mage,
            Assassin
        }
        #region FIELDS
        private int _health;
        private int _souls;
        private PlayerClass _playerClass;
        private int _strength;
        private int _dexterity;
        private int _intelligence;
        private int _faith;
        private int _estus;
        private int _playerLevel;
        private List<Location> _locationsVisited;







        #endregion

        #region PROPERTIES

        public int PlayerLevel
        {
            get { return _playerLevel; }
            set { _playerLevel = value; }
        }

        public int Souls
        {
            get { return _souls; }
            set { _souls = value; }
        }


        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public int Estus
        {
            get { return _estus; }
            set { _estus = value; }
        }


        public int Faith
        {
            get { return _faith; }
            set { _faith = value; }
        }


        public int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }


        public int Dexterity
        {
            get { return _dexterity; }
            set { _dexterity = value; }
        }


        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }


        public PlayerClass playerClass
        {
            get { return _playerClass; }
            set { _playerClass = value; }
        }


        public List<Location> LocationsVisited
        {
            get { return _locationsVisited; }
            set { _locationsVisited = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Player()
        {
            _locationsVisited = new List<Location>();
        }


        #endregion

        #region METHODS
        public bool HasVisited(Location location)
        {
            return _locationsVisited.Contains(location);
        }

        public override string Introduction()
        {
            string article = "a";

            List<string> vowels = new List<string>() { "A", "E", "I", "O", "U" };

            if (vowels.Contains(_playerClass.ToString().Substring(0, 1))) ;
            {
                article = "an";
            }

            return $"You are {base.Name}, also known as the Chosen Undead. You are {article} {_playerClass} tasked with traveling to Lordran, land of the Undead, in order to link the First Flame and break the Undead Curse.";
        }

        #endregion

    }
}
