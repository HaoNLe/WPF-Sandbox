using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Sandbox.Components;

namespace WPF_Sandbox.Views
{
    /// <summary>
    /// Interaction logic for FlattenedListView.xaml
    /// </summary>
    public partial class FlattenedListView : UserControl
    {
        public FlattenedListView()
        {
            InitializeComponent();
        }

        public ObservableCollection<Team> Teams
        {
            get { return (ObservableCollection<Team>)GetValue(TeamsProperty); }
            set { SetValue(TeamsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Teams.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TeamsProperty =
            DependencyProperty.Register("Teams", typeof(ObservableCollection<Team>), typeof(FlattenedListView), new PropertyMetadata(new ObservableCollection<Team>(), new PropertyChangedCallback(OnTeamsChanged)));

        public ObservableCollection<Actor> AllActors
        {
            get { return (ObservableCollection<Actor>)GetValue(AllActorsProperty); }
            set { SetValue(AllActorsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AllActors.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AllActorsProperty =
            DependencyProperty.Register("AllActors", typeof(ObservableCollection<Actor>), typeof(FlattenedListView), new PropertyMetadata(new ObservableCollection<Actor>()));

        public Actor SelectedActor
        {
            get { return (Actor)GetValue(SelectedActorProperty); }
            set { SetValue(SelectedActorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedActor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedActorProperty =
            DependencyProperty.Register("SelectedActor", typeof(Actor), typeof(FlattenedListView), new PropertyMetadata(new Actor()));

        private static void OnTeamsChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            FlattenedListView control = (FlattenedListView)sender;
            ObservableCollection<Actor> allActors = new ObservableCollection<Actor>();
            foreach (Team team in control.Teams)
            {
                allActors.AddRange(team.Actors);
            }
            control.AllActors = allActors;
        }
    }
}
