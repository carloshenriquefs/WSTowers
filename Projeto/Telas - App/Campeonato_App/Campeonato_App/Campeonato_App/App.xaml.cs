﻿using Campeonato_App.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
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