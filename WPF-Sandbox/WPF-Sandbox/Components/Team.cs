using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Sandbox.Components
{
    public class Team
    {
        public Team(List<Actor> actors)
        {
            Actors = new ObservableCollection<Actor>();
            Actors.AddRange(actors);
            Name = "Team Name";
        }

        private ObservableCollection<Actor> _actors;

        public ObservableCollection<Actor> Actors
        {
            get { return _actors; }
            set { _actors = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
    }
}
