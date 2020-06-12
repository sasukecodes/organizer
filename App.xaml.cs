using Xamarin.Forms;

namespace projectmain
{
    public partial class App : Application
    {
        string dbPath => FileAccessHelper.GetLocalFilePath("activitytoday.db3");

        public static activityrepository ActivityRepo { get; private set; }
        public App()
        {
            InitializeComponent();

            ActivityRepo = new activityrepository(dbPath);

            MainPage = new NavigationPage(new projectmain.MainPage());
            ContentPage aepage = new ContentPage();
            ContentPage aewearablepage = new ContentPage();
            ContentPage aehomepage = new ContentPage();
            ContentPage aetransportpage = new ContentPage();
            ContentPage aeofficepage = new ContentPage();
            ContentPage del = new ContentPage();


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
