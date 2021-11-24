

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UNOSquare.Resources;

namespace UNOSquare.ViewModels
{
	internal abstract class AViewModel: INotifyPropertyChanged
	{
		public string this[string index] => Messages.ResourceManager.GetString(index);

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}


		public void SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "")
		{
			if (EqualityComparer<T>.Default.Equals(backingStore, value))
			{
				return;
			}
			backingStore = value;
			OnPropertyChanged(propertyName);
		}
	}
}
