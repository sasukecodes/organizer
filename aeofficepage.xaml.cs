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
    public partial class aeofficepage : ContentPage
    {
        string[] activitylist = new string[] { "fan", "light", "ac", "doorlock" };             
        Picker eventselect = new Picker { Title = "events" };                               
        string pickerval = "";
        TimePicker stime = new TimePicker() { Time = new TimeSpan(13, 0, 0) };
        TimePicker etime = new TimePicker() { Time = new TimeSpan(13, 0, 0) };
        public aeofficepage()
        {
            InitializeComponent();

            foreach (string actName in activitylist)
            {
                eventselect.Items.Add(actName);
            }
            officegrid.Children.Add(eventselect, 0, 0);               
            Grid.SetColumnSpan(eventselect, 4);
            Grid.SetRowSpan(eventselect, 2);



            officegrid.Children.Add(stime, 0, 2);            
            Grid.SetColumnSpan(stime, 3);

            officegrid.Children.Add(etime, 0, 3);
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
                    string[] activityrows = { starte + ende + Convert.ToString(eventselect.SelectedIndex) + "05", starte + ende + activitylist[eventselect.SelectedIndex], "office", "05" };    
                    App.ActivityRepo.AddNewActivity(activityrows);

                    Browser.OpenAsync("http://192.168.1.105/" + "05/" + Convert.ToString(eventselect.SelectedIndex) + "/" + starte + "/" + ende, new BrowserLaunchOptions
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