

using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace UNOSquare.Behaviors
{
	internal class TextValidationBehavior : Behavior<Entry>
	{
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            bool isValid = !Regex.IsMatch(args.NewTextValue, @"[0-9]");
            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
        }
    }
}
