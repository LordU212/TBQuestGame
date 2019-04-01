using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Character : ObservableObject
    {
        public enum NpcType
        {
            Enemy,
            Boss,
            Merchant,
            Guide,
            Player
        }
        #region FIELDS
        protected int _id;
        protected string _name;
        protected int _locationId;
        protected NpcType _npctype;




        #endregion

        #region PROPERTIES


        public NpcType NPCType
        {
            get { return _npctype; }
            set { _npctype = value; }
        }


        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, NpcType npcType, int locationId)
        {
            _name = name;
            _npctype = npcType;
            _locationId = locationId;
        }

        #endregion

        #region METHODS
        public virtual string Introduction()
        {
            return $"People call me {_name}. What brings you here?";
        }


        #endregion

    }
}
