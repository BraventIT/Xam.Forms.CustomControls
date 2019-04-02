using System;
using System.Collections.Generic;
using Xam.Forms.CustomControls.ViewModels;
using Xamarin.Forms;

namespace Xam.Forms.CustomControls.Views
{
    public partial class CustomEntryView : ContentPage
    {
        CustomEntryViewModel ViewModel => BindingContext as CustomEntryViewModel;

        public CustomEntryView()
        {
            InitializeComponent();
            BindingContext = new CustomEntryViewModel();
            ViewModel.Navigation = Navigation;
        }

    }
}
