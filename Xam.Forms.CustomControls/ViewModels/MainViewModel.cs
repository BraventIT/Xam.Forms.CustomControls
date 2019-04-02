using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xam.Forms.CustomControls.Views;
using Xamarin.Forms;

namespace Xam.Forms.CustomControls.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        public ICommand EntrySelectedCommand { get; private set; }

        public MainViewModel()
        {
            EntrySelectedCommand = new Command(async() => await OnEntrySelected());

        }

        async Task OnEntrySelected()
        {
            await Navigation.PushAsync(new CustomEntryView());
        }
    }
}
