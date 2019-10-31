using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xf.simp2019.rssnews
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Services.NCFService service = new Services.NCFService();
            service.GetArticles();
            service.GetArticles_Completed += (sender, e) =>
            {
                var lista = e.Results;
            };

            MainPage = new MainPage();
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
