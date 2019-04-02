using System;
using System.Collections.Generic;
using Xam.Forms.CustomControls.ViewModels;
using Xamarin.Forms;

namespace Xam.Forms.CustomControls.Views
{
    public partial class MainView : ContentPage
    {
        MainViewModel ViewModel => BindingContext as MainViewModel;

        public MainView()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
            ViewModel.Navigation = Navigation;
            NavigationPage.SetBackButtonTitle(this, string.Empty);
        }
    }
}
