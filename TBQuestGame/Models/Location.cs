using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Location
    {

        #region FIELDS

        private int _id;
        private string _name;
        private string _description;
        private bool _accessible;
        private int _modifyExperiencePoints;
        private int _modifyHealth;
        private int _requiredSouls;
        private string _message;




        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public bool Accessible
        {
            get { return _accessible; }
            set { _accessible = value; }
        }


        public int ModifyExperiencePoints
        {
            get { return _modifyExperiencePoints; }
            set { _modifyExperiencePoints = value; }
        }

        public int RequiredSouls
        {
            get { return _requiredSouls; }
            set { _requiredSouls = value; }
        }


        public int ModifyHealth
        {
            get { return _modifyHealth; }
            set { _modifyHealth = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }



        #endregion

        #region CONSTRUCTORS

        #endregion

        #region METHODS

        public override string ToString()
        {
            return _name;
        }

        public bool IsAccessibleByExperiencePoints(int playerSouls)
        {
            return playerSouls >= _requiredSouls ? true : false;
        }


        #endregion
    }
}
