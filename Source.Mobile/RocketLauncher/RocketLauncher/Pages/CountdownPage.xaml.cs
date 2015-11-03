using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using RocketLauncher.ViewModels;

namespace RocketLauncher.Pages
{
	public partial class CountdownPage : ContentPage
	{
        protected CountdownViewModel ViewModel
        {
            get { return BindingContext as CountdownViewModel; }
            set { BindingContext = value; }
        }

        public CountdownPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        public CountdownPage(int? delay)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            ViewModel = new CountdownViewModel(delay);
        }

        public CountdownPage(CountdownViewModel viewModel)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            ViewModel = viewModel;
        }

        async void btnCancel_Clicked(object sender, EventArgs e)
        {
            if (!ViewModel.Launched)
                ViewModel.Cancelled = true;
            ViewModel.Countdown = null;
            await Task.Delay(1000);
            await Navigation.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            btnCancel_Clicked(null, EventArgs.Empty);
            //Task.Delay(1000).Wait();
            return true;
        }
    }
}
