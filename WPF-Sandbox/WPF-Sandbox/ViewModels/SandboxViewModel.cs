using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace WPF_Sandbox.ViewModels
{
    public class SandboxViewModel : BindableBase
    {
        public SandboxViewModel()
        {
            Teams = new ObservableCollection<Team>();
            Teams.Add(new Team());
            Teams.Add(new Team());
            Teams.Add(new Team());
        }
        private ObservableCollection<Team> _teams;

        public ObservableCollection<Team> Teams
        {
            get { return _teams; }
            set { _teams = value; }
        }

    }

    public class Team 
    {
        public Team()
        {
            Actors = new ObservableCollection<Actor>();
            Actors.Add(new Actor());
            Actors.Add(new Actor());
            Actors.Add(new Actor());
        }

        private ObservableCollection<Actor> _actors;

        public ObservableCollection<Actor> Actors
        {
            get { return _actors; }
            set { _actors = value; }
        }
    }

    public class Actor 
    {
        public Actor()
        {
            Random random = new Random();
            Id = random.Next(100);
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            string letter = Convert.ToString(shift + 65);
            Name = letter;
        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


    }

}
