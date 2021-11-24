

using UNOSquare.Services.Interfaces;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(UNOSquare.Droid.Services.Implementations.AppId))]
namespace UNOSquare.Droid.Services.Implementations
{
	internal class AppId : IAppId
	{
		public string Get => Platform.AppContext.PackageName;
	}
}