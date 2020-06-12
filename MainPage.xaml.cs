using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using projectmain.Models;

namespace projectmain
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        
      
        public MainPage()
        {
            InitializeComponent();

            //initializing stacks

           
            //first two rows
            //me
           

            var addevent1 = new ImageButton { Source = "addevent.png" };
            gridtable.Children.Add(addevent1, 1, 1);

            //try navigate
            addevent1.Clicked += (s, e) => Navigation.PushAsync(new aepage());

            //wearables
            

            var addevent2 = new ImageButton { Source = "addevent.png" };
            gridtable.Children.Add(addevent2, 2, 1);

            //try navigate
            addevent2.Clicked += (s, e) => Navigation.PushAsync(new aewearablepage());

            //home
            

            var addevent3 = new ImageButton { Source = "addevent.jpg" };
            gridtable.Children.Add(addevent3, 3, 1);

            //try navigate
            addevent3.Clicked += (s, e) => Navigation.PushAsync(new aehomepage());

            //transport
            

            var addevent4 = new ImageButton { Source = "addevent.jpg" };
            gridtable.Children.Add(addevent4, 4, 1);

            //try navigate
            addevent4.Clicked += (s, e) => Navigation.PushAsync(new aetransportpage());

            //office
            

            var addevent5 = new ImageButton { Source = "addevent.jpg" };
            gridtable.Children.Add(addevent5, 5, 1);

            //try navigate
            addevent5.Clicked += (s, e) => Navigation.PushAsync(new aeofficepage());

            //delete

            var del = new ImageButton {Source = "thrash" };
            gridtable.Children.Add(del, 0, 1);

            //try navigate

            del.Clicked += (s, e) => Navigation.PushAsync(new del());


            //
            //
            //
            //
            //adding events to stacklayout in lists
            //List<activity> elist = App.ActivityRepo.GetAllEvents();    

           

        }



        public void OnminionButtonClicked(object sender, EventArgs args)
        {
            List<activity> people = App.ActivityRepo.GetAllminion();             /////////////////////////modify
            
            meList.ItemsSource = people;
        }

        public void OnwearablesButtonClicked(object sender, EventArgs args)
        {
            List<activity> people = App.ActivityRepo.GetAllwearables();             /////////////////////////modify
            wearableList.ItemsSource = people;
        }

        public void OnhouseButtonClicked(object sender, EventArgs args)
        {
            List<activity> people = App.ActivityRepo.GetAllhouse();             /////////////////////////modify
            homeList.ItemsSource = people;
        }

        public void OntransportButtonClicked(object sender, EventArgs args)
        {
            List<activity> people = App.ActivityRepo.GetAlltransport();             /////////////////////////modify
            transportList.ItemsSource = people;
        }

        public void OnofficeButtonClicked(object sender, EventArgs args)
        {
            List<activity> people = App.ActivityRepo.GetAlloffice();             /////////////////////////modify
            officeList.ItemsSource = people;
        }
    }
}
