using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectmain
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class aewearablepage : ContentPage
    {
        string[] activitylist = new string[] { "fitband", "prosthetic", "locator", "sugarmonitor", "bpmonitor" };             
        Picker eventselect = new Picker { Title = "events" };                                
        string pickerval = "";
        TimePicker stime = new TimePicker() { Time = new TimeSpan(13, 0, 0) };
        TimePicker etime = new TimePicker() { Time = new TimeSpan(13, 0, 0) };

        public aewearablepage()
        {
            InitializeComponent();

            //add picker
            foreach (string actName in activitylist)
            {
                eventselect.Items.Add(actName);
            }
            wearablegrid.Children.Add(eventselect, 0, 0);               
            Grid.SetColumnSpan(eventselect, 4);
            Grid.SetRowSpan(eventselect, 2);



            wearablegrid.Children.Add(stime, 0, 2);           
            Grid.SetColumnSpan(stime, 3);

            wearablegrid.Children.Add(etime, 0, 3);
            Grid.SetColumnSpan(etime, 3);


            //execution
            /*eventselect.SelectedIndexChanged += (sender, args) =>
            {
                if (eventselect.SelectedIndex != -1)
                {
                    pickerval = activitylist[eventselect.SelectedIndex];
                }
            };*/

            addevent.Clicked += (sender, args) =>
            {
                if (eventselect.SelectedIndex != -1)
                {
                    string starte = Convert.ToString(stime.Time);
                    string ende = Convert.ToString(etime.Time);
                    //type or device no = eventselect.SelectedIndex
                    //homepagecategory = 02

                    //database
                    string[] activityrows = { starte + ende + Convert.ToString(eventselect.SelectedIndex) + "02", starte + ende + activitylist[eventselect.SelectedIndex], "wearables", "02" };      
                    App.ActivityRepo.AddNewActivity(activityrows);

                    Browser.OpenAsync("http://192.168.1.105/" + "02/" + Convert.ToString(eventselect.SelectedIndex) + "/" + starte + "/" + ende, new BrowserLaunchOptions
                    {
                        LaunchMode = BrowserLaunchMode.SystemPreferred,
                        TitleMode = BrowserTitleMode.Show,
                        PreferredToolbarColor = Color.AliceBlue,
                        PreferredControlColor = Color.Violet
                    });
                }
            };
        }
    }
}