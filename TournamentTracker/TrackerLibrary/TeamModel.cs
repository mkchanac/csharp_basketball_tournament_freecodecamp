using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//prop tab tab = property
//ctor tab tab = constructor

namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();  //constructor in here, new things
        public string TeamName { get; set; }

        //public TeamModel()
        //{
        //    TeamMembers = new List<Person>();
        //}
    }
}
