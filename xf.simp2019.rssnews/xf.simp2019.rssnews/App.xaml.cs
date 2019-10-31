using Xamarin.Forms;

namespace xf.simp2019.rssnews
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Views.ArticlesListPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}