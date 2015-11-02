﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using RocketLauncher.ViewModels;

namespace RocketLauncher
{
	public partial class LaunchPage : ContentPage
	{
        protected LaunchViewModel ViewModel
        {
            get { return BindingContext as LaunchViewModel; }
        }

		public LaunchPage()
		{
			InitializeComponent();
		}

        async void btnArm_Clicked(object sender, EventArgs e)
        {
            if (!ViewModel.Connected)
            {
                ViewModel.Armed = false;
                await DisplayAlert("Not Connected", "Please select 'Configure' and pair with a rocket launcher", "OK");
            }
            else
            {
                ViewModel.Armed = !ViewModel.Armed;
            }
            btnArm.Text = ViewModel.Armed ? "DISARM" : "ARM";
        }

        async void btnLaunch_Clicked(object sender, EventArgs e)
        {
            if (ViewModel.Armed)
                await DisplayAlert("Launching!", LaunchString(ViewModel.Delay), "Cancel");
            else
                await DisplayAlert("Not Armed", "Rocket is not Armed", "OK");
        }

        void sldDelay_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //ViewModel.Delay = (int)e.NewValue;
        }

        void btnConfigure_Clicked(object sender, EventArgs e)
        {
            if (!ViewModel.Connected)
            {
                ViewModel.Connected = true;
                ViewModel.DeviceName = "Test";
            }
            else
            {
                ViewModel.Connected = false;
                ViewModel.DeviceName = null;
                ViewModel.Armed = false;
            }
        }

        private string LaunchString(int remaining)
        {
            if (remaining <= 0)
                return "Launch!!!";
            return String.Format("Launching in T-{0} seconds...", remaining);
        }
    }
}
