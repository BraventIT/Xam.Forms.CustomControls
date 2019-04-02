using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xam.Forms.CustomControls.ViewModels
{
    public class CustomEntryViewModel: BaseViewModel
    {
        public ICommand SaveCommand { get; private set; }

        public CustomEntryViewModel()
        {
            SaveCommand = new Command(async () => await OnSave());
        }

        async Task OnSave()
        {
            await Application.Current.MainPage.DisplayAlert(
                    string.Empty,
                    "La información se ha guardado correctamente",
                    "OK");
        }
    }
}
