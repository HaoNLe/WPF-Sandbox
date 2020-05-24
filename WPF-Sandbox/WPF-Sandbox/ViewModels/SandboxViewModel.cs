using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using WPF_Sandbox.Components;

namespace WPF_Sandbox.ViewModels
{
    public class SandboxViewModel : BindableBase
    {
        public DelegateCommand PopulateTeams { get; set; }
        public SandboxViewModel()
        {
            PopulateTeams = new DelegateCommand(GenerateTeams);
            Teams = new ObservableCollection<Team>
            {
                new Team(new List<Actor>()
                { 
                    new Actor(){Id=12, Name="Brad Pitt"},
                    new Actor(){Id=23, Name="Angelina Jolie"}
                }),
                new Team(new List<Actor>()
                {
                    new Actor(){Id=387, Name="Joseph Gordon Levitt"},
                    new Actor(){Id=2, Name="Leonardo DiCaprio"}
                }),
                new Team(new List<Actor>()
                {
                    new Actor(){Id=72, Name="Johnny Depp"}
                })
            };
        }
        private ObservableCollection<Team> _teams;

        public ObservableCollection<Team> Teams
        {
            get { return _teams; }
            set { _teams = value; }
        }

        private Actor _selectedActor;

        public Actor SelectedActor
        {
            get { return _selectedActor; }
            set { _selectedActor = value; }
        }

        private void GenerateTeams()
        {
            Teams.Add(new Team(new List<Actor>()
                {
                    new Actor(){Id=159, Name="New Actor"}
                }));
        }
    }
}
