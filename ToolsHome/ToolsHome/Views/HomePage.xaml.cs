﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToolsHome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void mts2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mts2());
        }

        private async void ToDo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ToDo());
        }
    }
}