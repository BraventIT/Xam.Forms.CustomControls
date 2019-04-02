using System;
using Xamarin.Forms;

namespace Xam.Forms.CustomControls.CustomControls
{
    public class CustomEntry: Entry
    {

        public CustomEntry()
        {
            Completed -= NoBorderEntry_Completed;
            Completed += NoBorderEntry_Completed;
        }

        #region Properties
        public static readonly BindableProperty NextEntryNameProperty =
          BindableProperty.Create(
            nameof(NextEntryName), 
            typeof(string), 
            typeof(CustomEntry), 
            string.Empty, 
            BindingMode.OneWay);

        public string NextEntryName
        {
            get { return (string)GetValue(NextEntryNameProperty); }
            set { SetValue(NextEntryNameProperty, value); }
        }
        #endregion

        #region Events
        public new event EventHandler<EventArgs> Completed;

        public void InvokeCompleted()
        {
            this.Completed?.Invoke(this, null);
        }

        void NoBorderEntry_Completed(object sender, EventArgs e)
        {
            if (this.ReturnType == ReturnType.Done)
            {
                Unfocus();
                ExecuteCommand();
            }

            if (ReturnType == ReturnType.Next)
            {
                FocusOnNextEntry();
            }
        }
        #endregion

        #region Private voids

        Page GetCurrentPage() 
        {
            if (Application.Current.MainPage is NavigationPage navigationPage)
            {
                return navigationPage.CurrentPage;
            }
            return null;
        }

        CustomEntry GetNextEntry(Page currentPage)
        {
            return currentPage?.FindByName<CustomEntry>(NextEntryName);
        }

        void FocusOnNextEntry()
        {
            Page currentPage = GetCurrentPage();
            var nextEntry = GetNextEntry(currentPage);
            nextEntry?.Focus();
        }

        void ExecuteCommand() 
        {
            if (Device.RuntimePlatform == Device.Android)
                ReturnCommand?.Execute(null);
        }
        #endregion
    }
}
