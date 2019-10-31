﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xf.simp2019.rssnews
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ViewModels.ArticlesListViewModel articlesListViewModel = new ViewModels.ArticlesListViewModel();

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
