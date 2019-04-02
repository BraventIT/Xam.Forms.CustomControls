using System;
using UIKit;
using Xam.Forms.CustomControls.CustomControls;
using Xam.Forms.CustomControls.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(IosCustomEntryRenderer))]
namespace Xam.Forms.CustomControls.iOS.Renderers
{
    public class IosCustomEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.ShouldReturn += Control_ShouldReturn;
            }
            if (e.OldElement != null)
            {
                Control.ShouldReturn -= Control_ShouldReturn;
            }

        }

        bool Control_ShouldReturn(UITextField textField)
        {
            (Element as CustomEntry)?.InvokeCompleted();
            return true;
        }

    }

}
