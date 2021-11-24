

using Android.Content;
using UNOSquare.Droid.Renders;
using UNOSquare.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace UNOSquare.Droid.Renders
{
	internal class BorderlessEntryRenderer : EntryRenderer
	{
        public BorderlessEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement is null)
            {
                Control.Background = null;
            }
        }
    }
}