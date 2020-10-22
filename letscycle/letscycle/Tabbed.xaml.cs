﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace letscycle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabbed : TabbedPage
    {
        public Tabbed()
        {
            InitializeComponent();
            BackgroundColor = Color.FromHex("#E1EEF0");
            BarBackgroundColor = Color.FromHex("#F2C299");
        }
    }
}