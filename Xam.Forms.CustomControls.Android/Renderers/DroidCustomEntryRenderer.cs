using System;
using Android.Content;
using Android.Widget;
using Xam.Forms.CustomControls.CustomControls;
using Xam.Forms.CustomControls.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(DroidCustomEntryRenderer))]
namespace Xam.Forms.CustomControls.Droid.Renderers
{
    public class DroidCustomEntryRenderer : EntryRenderer
    {
        public DroidCustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.EditorAction += Control_EditorAction;
            }
        }

        void Control_EditorAction(object sender, TextView.EditorActionEventArgs e)
        {
            (Element as CustomEntry)?.InvokeCompleted();
        }

    }
}
