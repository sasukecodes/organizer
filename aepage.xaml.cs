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
    public partial class aepage : ContentPage
    {
        string[] activitylist = new string[] { "wakeup", "workout", "lecture", "meeting", "travel", "task1" };
        Picker eventselect = new Picker { Title = "events" };
        string pickerval = "";

        TimePicker stime = new TimePicker() { Time = new TimeSpan(13, 0, 0) };
        TimePicker etime = new TimePicker() { Time = new TimeSpan(13, 0, 0) };


        public aepage()
        {
            InitializeComponent();

            //add picker
            foreach (string actName in activitylist)
            {
                eventselect.Items.Add(actName);
            }
            maingrid.Children.Add(eventselect, 0, 0);
            Grid.SetColumnSpan(eventselect, 4);
            Grid.SetRowSpan(eventselect, 2);



            maingrid.Children.Add(stime, 0, 2);
            Grid.SetColumnSpan(stime, 3);

            maingrid.Children.Add(etime, 0, 3);
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
                    string[] activityrows = { starte + ende + Convert.ToString(eventselect.SelectedIndex) + "01", starte + ende + activitylist[eventselect.SelectedIndex], "me", "01" };
                    App.ActivityRepo.AddNewActivity(activityrows);

                    Browser.OpenAsync("http://192.168.1.105/" + "01/" + Convert.ToString(eventselect.SelectedIndex) + "/" + starte + "/" + ende, new BrowserLaunchOptions
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