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
            InitializeComponent();
        }

        public CountdownPage(int delay)
        {
            ViewModel = new CountdownViewModel(delay);
            InitializeComponent();
        }

        public CountdownPage(CountdownViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
        }

        async void btnCancel_Clicked(object sender, EventArgs e)
        {
            ViewModel.Countdown = null;
            ViewModel.Cancelled = true;
            await Navigation.PopAsync();
        }
    }
}
