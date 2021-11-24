

using Acr.UserDialogs;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using UNOSquare.Models;
using UNOSquare.Services.Interfaces;
using Xamarin.Forms;

namespace UNOSquare.ViewModels
{
	internal sealed class MainViewModel: AViewModel
	{
		private ObservableCollection<ItemCollection> _items;
		public ObservableCollection<ItemCollection> Items
		{
			get => _items;
			set => SetProperty(ref _items, value);
		}

		public string AppId
		{
			get => DependencyService.Get<IAppId>().Get;
		}

		private string branch;
		public string Branch
		{
			get => branch;
			set => SetProperty(ref branch, value);
		}

		private string model;
		public string Model
		{
			get => model;
			set => SetProperty(ref model, value);
		}

		private string year;
		public string Year
		{
			get => year;
			set => SetProperty(ref year, value);
		}

		public ICommand AddCommand { get; private set; }

		public MainViewModel()
		{
			_items = new ObservableCollection<ItemCollection>
			{
				new ItemCollection("UNOSquare", "UNOSquare", "2021"),
				new ItemCollection("UNOSquare_1", "UNOSquare_1", "2022")
			};

			AddCommand = new Command(() => OnAdd());
		}

		private void OnAdd()
		{
			if (string.IsNullOrEmpty(Branch) || string.IsNullOrEmpty(Model) || string.IsNullOrEmpty(Year) )
			{
				UserDialogs.Instance.Toast(new ToastConfig(this["NeedAllParametrs"]).SetBackgroundColor(Color.Red).SetMessageTextColor(Color.White).SetDuration(10000).SetPosition(ToastPosition.Bottom));
				return;
			}

			if (_items.Any(x => x.Branch == Branch || x.Model == Model))
			{
				UserDialogs.Instance.Toast(new ToastConfig(this["NotDuplicated"]).SetBackgroundColor(Color.Red).SetMessageTextColor(Color.White).SetDuration(10000).SetPosition(ToastPosition.Bottom));
				return;
			}

			Items.Add(new ItemCollection(branch, model, year));
			Branch = string.Empty;
			Model = string.Empty;
			Year = string.Empty;
			//await Task.CompletedTask;
		}
	}
}
