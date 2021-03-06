﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace letscycle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelpPage : ContentPage
    {
        public HelpPage()
        {
            InitializeComponent();
            BindingContext = this; 
        }
        public ICommand TapCommand => new Command<string>(OpenBrowser);


        void OpenBrowser(string url)
        {
            Device.OpenUri(new Uri(url));
        }
    }
    
}