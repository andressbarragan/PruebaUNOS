

using Foundation;
using UNOSquare.Services.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(UNOSquare.iOS.Services.Implementations.AppId))]
namespace UNOSquare.iOS.Services.Implementations
{
	
	internal class AppId : IAppId
	{
		public string Get => NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleIdentifier")?.ToString();
	}
}