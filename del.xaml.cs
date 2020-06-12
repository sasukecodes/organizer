using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectmain.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectmain
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class del : ContentPage
    {
        ImageButton minion = new ImageButton { Source = "minion" };
        ImageButton wearables = new ImageButton { Source = "wearables" };
        ImageButton house = new ImageButton { Source = "house" };
        ImageButton transport = new ImageButton { Source = "transport" };
        ImageButton office = new ImageButton { Source = "office" };
        Button delfinal = new Button { Text = "DELETE", BackgroundColor = Color.Red };
        Picker delpicker = new Picker { Title = "DeleteEvent" };

        List<activity> acts = new List<activity>();
        public del()
        {
            InitializeComponent();
            
            deletegrid.Children.Add(minion, 0, 0);

            
            deletegrid.Children.Add(wearables, 0, 1);

            
            deletegrid.Children.Add(house, 1, 0);

            
            deletegrid.Children.Add(transport, 1, 1);

            
            deletegrid.Children.Add(office, 0, 2);

            deletegrid.Children.Add(delfinal, 0, 4);         /////////add  in the end
            Grid.SetColumnSpan(delfinal, 2);

            deletegrid.Children.Add(delpicker, 0, 3);         ///////add un the end
            Grid.SetColumnSpan(delpicker, 2);

           

            minion.Clicked += (sender, args) =>
            {
                List<activity> people = App.ActivityRepo.GetAllminion();             /////////////////////////modify
                int c = people.Count;
                for (int d = 0; d<c; d++)
                {
                    acts.Add(people[d]);
                }
                for (int d=0; d<c; d++)
                {
                    string inter = people[d].Name;
                    delpicker.Items.Add(inter);
                }
            };

            wearables.Clicked += (sender, args) =>
            {
                List<activity> people = App.ActivityRepo.GetAllwearables();             /////////////////////////modify
                int c = people.Count;
                for (int d = 0; d < c; d++)
                {
                    acts.Add(people[d]);
                }
                for (int d = 0; d < c; d++)
                {
                    string inter = people[d].Name;
                    delpicker.Items.Add(inter);
                }
            };

            house.Clicked += (sender, args) =>
            {
                List<activity> people = App.ActivityRepo.GetAllhouse();             /////////////////////////modify
                int c = people.Count;
                for (int d = 0; d < c; d++)
                {
                    acts.Add(people[d]);
                }
                for (int d = 0; d < c; d++)
                {
                    string inter = people[d].Name;
                    delpicker.Items.Add(inter);
                }
            };

            transport.Clicked += (sender, args) =>
            {
                List<activity> people = App.ActivityRepo.GetAlltransport();             /////////////////////////modify
                int c = people.Count;
                for (int d = 0; d < c; d++)
                {
                    acts.Add(people[d]);
                }
                for (int d = 0; d < c; d++)
                {
                    string inter = people[d].Name;
                    delpicker.Items.Add(inter);
                }
            };

            office.Clicked += (sender, args) =>
            {
                List<activity> people = App.ActivityRepo.GetAlloffice();             /////////////////////////modify
                int c = people.Count;
                for (int d = 0; d < c; d++)
                {
                    acts.Add(people[d]);
                }
                for (int d = 0; d < c; d++)
                {
                    string inter = people[d].Name;
                    delpicker.Items.Add(inter);
                }
            };

            delfinal.Clicked += (sender, args) =>
            {
                if(delpicker.SelectedIndex != -1)
                {
                    App.ActivityRepo.DelActivity(acts[delpicker.SelectedIndex]);

                    Browser.OpenAsync("http://192.168.1.105/d/" + acts[delpicker.SelectedIndex].Interval, new BrowserLaunchOptions
                    {
                        LaunchMode = BrowserLaunchMode.SystemPreferred,
                        TitleMode = BrowserTitleMode.Show,
                        PreferredToolbarColor = Color.AliceBlue,
                        PreferredControlColor = Color.Violet
                    });
                }
            };

           
        }

        /*
        public void OnminionButtonClicked(object sender, EventArgs args)
        {
            List<activity> people = App.ActivityRepo.GetAllminion();             /////////////////////////modify
            delpicker.ItemsSource = people;
        }

        public void OnwearablesButtonClicked(object sender, EventArgs args)
        {
            List<activity> people = App.ActivityRepo.GetAllwearables();             /////////////////////////modify
            delpicker.ItemsSource = people;
        }

        public void OnhouseButtonClicked(object sender, EventArgs args)
        {
            List<activity> people = App.ActivityRepo.GetAllhouse();             /////////////////////////modify
            delpicker.ItemsSource = people;
        }

        public void OntransportButtonClicked(object sender, EventArgs args)
        {
            List<activity> people = App.ActivityRepo.GetAlltransport();             /////////////////////////modify
            delpicker.ItemsSource = people;
        }

        public void OnofficeButtonClicked(object sender, EventArgs args)
        {
            List<activity> people = App.ActivityRepo.GetAlloffice();             /////////////////////////modify
            delpicker.ItemsSource = people;
        }

        public void OnfinaldeleteClicked(object sender, EventArgs args)
        {
            if(delpicker.SelectedIndex != -1)
            {
                App.ActivityRepo.DelActivity((people[delpicker.SelectedIndex]).Interval);
            }
        }
        */
    }
}